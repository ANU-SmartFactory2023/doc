import cv2
import numpy as np
import time
import RPi.GPIO as GPIO
from pyzbar import pyzbar

def INIT_1():
    GPIO.setwarnings(False)
    GPIO.setmode(GPIO.BOARD)
    GPIO.setup(on,GPIO.OUT,initial=GPIO.LOW)

on = 19

def capture():
    GPIO.output(on,1)
    capture_sample = cv2.VideoCapture(0)
    capture_sample.set(cv2.CAP_PROP_FRAME_WIDTH, 1280)
    capture_sample.set(cv2.CAP_PROP_FRAME_HEIGHT, 720)
    ret, frame = capture_sample.read() 
    cv2.imwrite('a.png', frame)
    img = cv2.imread('a.png')
    GPIO.output(on,0)
    return img

def qr(img):
    decoded = pyzbar.decode(img)

    for d in decoded: 
        x, y, w, h = d.rect

        barcode_data = d.data.decode("utf-8")
        return barcode_data

def classify(img):
    hsv_img = cv2.cvtColor(img, cv2.COLOR_BGR2HSV) 

    bound_lower = np.array([0,0,0]) 
    bound_upper = np.array([100, 255, 255]) 

    mask = cv2.inRange(hsv_img, bound_lower, bound_upper) 

    kernel = np.ones((5,5),np.uint8) 
    mask = cv2.morphologyEx(mask, cv2.MORPH_CLOSE, kernel)
    mask = cv2.morphologyEx(mask, cv2.MORPH_OPEN, kernel)

    seg_img = cv2.bitwise_and(img, img, mask=mask)

    blur = cv2.GaussianBlur(seg_img, ksize=(15,15), sigmaX=0)
    edged = cv2.Canny(blur, 50, 250)
    
    kernel = cv2.getStructuringElement(cv2.MORPH_RECT, (7,7))
    closed = cv2.morphologyEx(edged, cv2.MORPH_CLOSE, kernel)
    contours, _ = cv2.findContours(closed.copy(),cv2.RETR_EXTERNAL, cv2.CHAIN_APPROX_SIMPLE)

    contours_xy = np.array(contours)
    contours_xy.shape
    x_min= 0

    value = list()
    for i in range(len(contours_xy)):
        for j in range(len(contours_xy[i])):
            value.append(contours_xy[i][j][0][0]) 
            x_min = min(value)
            
    y_min = 0
    value = list()

    for i in range(len(contours_xy)):
        for j in range(len(contours_xy[i])):
            value.append(contours_xy[i][j][0][1]) 
            y_min = min(value)
    
    img_trim = img[y_min+30:y_min+490, x_min+30:x_min+1110]
    bgr = img_trim[:,:,:3]
    
    CLASSIFY_RESULT = 4

    color_mean = cv2.mean(bgr)
    aver = sum(color_mean)/3
    
    if max(color_mean)<aver+20 :
        if color_mean[0]<125:
            CLASSIFY_RESULT = 3     # hot
        else:
            CLASSIFY_RESULT = 1     # dead
            out = bgr.copy()
            bgr = 225 - out
            
        blurred = cv2.GaussianBlur(bgr, (5, 5), 0)

        gray = cv2.cvtColor(blurred, cv2.COLOR_BGR2GRAY)

        ret, thresh = cv2.threshold(gray, 10, 250, cv2.THRESH_BINARY)
        thresh = cv2.erode(thresh, None, iterations=2)

        contours = cv2.findContours(thresh.copy(), cv2.RETR_EXTERNAL, cv2.CHAIN_APPROX_SIMPLE)
        
    else:
        if round(color_mean[0]) > (round(color_mean[1]) and round(color_mean[2])): 
            mask = cv2.inRange( bgr, (0,0,0), (255,50,120))
            bgr[mask==255] = (0,0,0)
            mask = cv2.inRange( bgr, (0,0,0), (255,120,50))
            bgr[mask==255] = (0,0,0)
        if round(color_mean[1]) > (round(color_mean[0]) and round(color_mean[2])): 
            mask = cv2.inRange( bgr, (0,0,0), (120,255,50))
            bgr[mask==255] = (0,0,0)    
            mask = cv2.inRange( bgr, (0,0,0), (50,255,120))
            bgr[mask==255] = (0,0,0)
        if round(color_mean[2]) > (round(color_mean[1]) and round(color_mean[0])): 
            mask = cv2.inRange( bgr, (0,0,0), (120,50,255))
            bgr[mask==255] = (0,0,0)
            mask = cv2.inRange( bgr, (0,0,0), (50,120,255))
            bgr[mask==255] = (0,0,0)
    
    blurred = cv2.GaussianBlur(bgr, (5, 5), 0)
    gray = cv2.cvtColor(blurred, cv2.COLOR_BGR2GRAY)
    ret, thresh = cv2.threshold(gray, 100, 255, cv2.THRESH_BINARY)
    thresh = cv2.erode(thresh, None, iterations=2)
    
    contours = cv2.findContours(thresh.copy(), cv2.RETR_EXTERNAL, cv2.CHAIN_APPROX_SIMPLE)

    if len(contours) == 2:
        contours = contours[0]
    elif len(contours) == 3:
        contours = contours[1]
        

    cnt = len(contours)
    if color_mean[0]>250 and color_mean[1]>250 and color_mean[2]>250:
        cnt = cnt-1

    print('cnt:', cnt)

    if cnt==0:
        CLASSIFY_RESULT=2
        
    return CLASSIFY_RESULT
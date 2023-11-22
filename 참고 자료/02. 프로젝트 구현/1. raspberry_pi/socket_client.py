
# -*- coding: utf-8 -*-

import socket
import threading
import errno
import select

def recv_d():
    try:
        while True:
            recv_data = client_socket.recv(256).decode('utf-8')
            if not recv_data:
                # 연결이 끊어졌을 때의 처리
                print("Connection closed by the server.")
                break

            # 데이터 처리 로직 추가
            print("Received:", recv_data)
    except BlockingIOError as e1:
        print(type(e1))



def send(send_data):
    try:
        client_socket.sendall(send_data.encode())
    except socket.error as e:
        if e.errno != errno.EAGAIN:
            raise e
        print('Blocking with', len(send_data), 'remaining')
        select.select([], [client_socket], [])


def connect_d(ip, port):
    try:
        client_socket.connect((ip, port))
        client_socket.setblocking(False)
        print("Connected to the server")
        return True
    except socket.error as e:
        print(f"Error while connecting: {e}")
        return False

client_socket = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
#client_socket.setblocking(False)

# 서버
#ip = '127.0.0.1'
# ip = '192.168.0.35'
# port = 8000

if connect_d('127.0.0.1', 8000):
    # 데이터 수신 및 송신을 위한 스레드 생성
    recv_thread = threading.Thread(target=recv_d)
    send_thread = threading.Thread(target=send, args=(client_socket,))

    # 스레드 시작
    recv_thread.start()
    send_thread.start()

    # 스레드 종료 대기
    recv_thread.join()
    send_thread.join()
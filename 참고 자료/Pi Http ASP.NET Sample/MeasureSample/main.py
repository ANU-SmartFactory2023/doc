import random
import time
from measure import Measure

# 임시 랜덤 함수
def getSonicValue() -> int :
    return random.random() * 10

# 최소값 ~ 최대값 사이의 값들만 저장하고, 평균 계산한다.
min = 3
max = 8
m = Measure( min, max )

step = 0
count = 0
running = True

while running :
    time.sleep( 0.001 )
    match step:
        case 0: 
            result = getSonicValue()
            m.add( result ) # 센서에서 얻은 값을 measure 클래스에 저장한다.
            if count > 100:
                step += 1
            else:
                count += 1
                
        case 1:
            avg = m.getAverage() # 평균 계산.
            print( f"avg : {avg}") 
            running = False
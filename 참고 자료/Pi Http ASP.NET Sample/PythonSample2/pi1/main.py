import sys, os
sys.path.append(os.path.dirname(os.path.abspath(os.path.dirname(__file__))))

from common import sensor

sensor.sensor_value = 10

print( sensor.sensor_value )


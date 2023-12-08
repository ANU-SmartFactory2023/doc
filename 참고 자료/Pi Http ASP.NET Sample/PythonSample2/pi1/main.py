import sys, os
sys.path.append(os.path.dirname(os.path.abspath(os.path.dirname(__file__))))

from common.sensor import Sensor

Sensor.sensor_value = 10

print( Sensor.sensor_value )

Sensor.get_ultra()


#16T2108G

import RPi.GPIO as GPIO
from time import sleep

GPIO.setmode(GPIO.BCM)
SW = 21 #スイッチ
SW2 = 20  #cds
SW3 = 16 #LED(白)
SW4 = 13 #LED(青)
SW5 = 19 #LED(赤)
SW6 = 26 #LED(緑)
GPIO.setup(SW,GPIO.IN,pull_up_down=GPIO.PUD_UP)
GPIO.setup(SW2,GPIO.IN,pull_up_down=GPIO.PUD_UP)
GPIO.setup(SW3,GPIO.OUT)
GPIO.setup(SW4,GPIO.OUT)
GPIO.setup(SW5,GPIO.OUT)
GPIO.setup(SW6,GPIO.OUT)
s = 0
t = 0
def checkSW(pin): #スイッチ
    global s
    s = 1
def checkSW2(high): #電圧比較(cds)
    global t
    if GPIO.input(SW2)==GPIO.HIGH:
        t =1
GPIO.add_event_detect(SW,GPIO.FALLING,callback=checkSW,bouncetime=200)
GPIO.add_event_detect(SW2,GPIO.RISING,callback=checkSW2,bouncetime=200)
try:
    while True:
        GPIO.output(SW3,GPIO.HIGH)
        print("no")
        s=0
        if t==1:
            print("ON")
            GPIO.output(SW3,GPIO.HIGH)
            if s==1:
                print("OFF")
                GPIO.output(SW3,GPIO.LOW)
                t=0
        
        sleep(0.5)
        
except KeyboardInterrupt:
    pass

GPIO.cleanup()


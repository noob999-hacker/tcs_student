import pyxel 

x = 0
y = 0
enemy_x=90
enemy_y=90

pyxel.init(400,400)
           
def update():
    global x, y, enemy_x, enemy_y
    if pyxel.btn(pyxel.KEY_RIGHT):
        x+=1
    if pyxel.btn(pyxel.KEY_LEFT):
        x-=1
    if pyxel.btn(pyxel.KEY_UP):
        y-=1
    if pyxel.btn(pyxel.KEY_DOWN):
        y+=1
    
    

    
def draw():
   pyxel.cls(15)
   pyxel.rect(x,y,6,6,12)
   pyxel.rect(enemy_x, enemy_y,10,10,3)
   
pyxel.run(update, draw)

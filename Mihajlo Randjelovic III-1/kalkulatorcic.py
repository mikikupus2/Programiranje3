from tkinter import *
def buttonclick(arg):
    print(arg)
    entry.insert(0,arg)
screen = Tk()
button1 = Button(screen,text= "1" ,height = 3, width = 10, command = lambda:buttonclick(1))
button2 = Button(screen,text= "2" ,height = 3, width = 10, command = lambda:buttonclick(2))
button3 = Button(screen,text= "3" ,height = 3, width = 10,command = lambda:buttonclick(3))
button4 = Button(screen,text= "4" ,height = 3, width = 10,command = lambda:buttonclick(4))
button5 = Button(screen,text= "5" ,height = 3, width = 10,command = lambda:buttonclick(5))
button6 = Button(screen,text= "6" ,height = 3, width = 10,command = lambda:buttonclick(6))
button7 = Button(screen,text= "7" ,height = 3, width = 10,command = lambda:buttonclick(7))
button8 = Button(screen,text= "8" ,height = 3, width = 10,command = lambda:buttonclick(8))
button9 = Button(screen,text= "9" ,height = 3, width = 10,command = lambda:buttonclick(9))
button0 = Button(screen,text= "0" ,height = 3, width = 10,command = lambda:buttonclick(0))
buttonminus = Button(screen,text= "-" ,height = 3, width = 10,command = lambda:buttonclick("-"))
buttonplus = Button(screen,text= "+" ,height = 3, width = 10,command = lambda:buttonclick("+"))
entry = Entry(screen,width = 40)
screen.grid()
entry.grid(column = 0, row = 0,columnspan = 3)
button9.grid(column = 2, row = 1)
button8.grid(column = 1, row =1)
button7.grid(column = 0, row =1)
button6.grid(column = 2, row =2)
button5.grid(column = 1, row =2)
button4.grid(column = 0, row =2)
button3.grid(column = 2, row =3)
button2.grid(column = 1, row =3)
button1.grid(column = 0, row =3)
button0.grid(column = 1, row = 4)
buttonplus.grid(column = 0, row = 4)
buttonminus.grid(column = 2, row =4)

screen.mainloop()
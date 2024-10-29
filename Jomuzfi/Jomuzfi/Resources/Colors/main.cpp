#include <iostream>
#include <graphics.h>
#include <stdlib.h>
#include <string.h>
#include <fstream>
#define MAXCOUNT 30
#include <conio.h>
#include <math.h>
#include <dos.h>

using namespace std;
void stickman(int &x,int &y)
{
    int ra=20;
    setcolor(WHITE);
    circle(x,y,ra);//cap
    setfillstyle(SOLID_FILL,WHITE);
    floodfill(x,y,WHITE);

    line(x,y+20,x,y+100);//corp
    line(x,y+100,x-30,y+140);//piciorul stang
    line(x,y+100,x+30,y+140);//piciorul drept
    line(x,y+70,x-30,y+25);//mana stanga
    line(x,y+70,x+30,y+25);//mana dreapta
}
void dinge(int x,int y, int r)
{
    setcolor(RED);
    circle(x,y,r);
    setfillstyle(SOLID_FILL,RED);
    floodfill(x,y,RED);
    setcolor(GREEN);
    circle(x,y+200,r);
    setfillstyle(SOLID_FILL,GREEN);
    floodfill(x,y+200,GREEN);
    setcolor(YELLOW);
    circle(x,y+400,r);
    setfillstyle(SOLID_FILL,YELLOW);
    floodfill(x,y+400,YELLOW);

}

struct punct{double x, y;};
int iteratii=5;
int l=400;              //dimensiunea ferestrei
int mode=0;           //modul de lucru
int dly = 2;            //delay

punct punct_treime(punct A, punct B){               //Returneaza coordonatele punctului de pe segmentul AB situat la 1/3 de A
    punct C;
    C.x = A.x + (B.x - A.x)/3;
    C.y = A.y + (B.y - A.y)/3;
    return C;
}

punct punct_mij(punct A, punct B){              //Returneaza coordonatele punctului care  impreuna cu A si B formeaza un triunghi echilateral
    punct E;
    E.x = A.x + (cos(M_PI/3) * (B.x - A.x) - sin(M_PI/3) * (B.y - A.y));
    E.y = A.y + (sin(M_PI/3) * (B.x - A.x) + cos(M_PI/3) * (B.y - A.y));
    return E;
}

void draw(punct A, punct B, punct C, punct D, punct E){     //Deseneaza o linie franta care uneste cele 5 puncte in ordine
    moveto(A.x, A.y);
    lineto(B.x, B.y); delay(dly);
    lineto(C.x, C.y); delay(dly);
    lineto(D.x, D.y); delay(dly);
    lineto(E.x, E.y);
}

void koch_line(punct A, punct E, int n=1){          //Imparte segmentul in 3 subsegmente generand al trilea punct(varful triunghiului cu subsegmentul din mijloc ca baza)
    punct B, C, D;
    B = punct_treime(A, E);
    D = punct_treime(E, A);
    C = punct_mij(B, D);
    if (n<iteratii) {
        koch_line(A, B, n+1);
        koch_line(B, C, n+1);
        koch_line(C, D, n+1);
        koch_line(D, E, n+1);
    }
    else draw(A, B, C, D, E);
}

void koch_snowflake(punct A, punct B, punct C){         //Apeleaza functia de generat puncte pe fiecare din laturile unui triunghi initial
    koch_line(A, B);
    koch_line(B, C);
    koch_line(C, A);
    if (mode) {
        setfillstyle(CLOSE_DOT_FILL, WHITE);        //Seteaza culoarea cu care va fi umplut fulgul
        floodfill(getmaxx()/2, getmaxy()/2, WHITE); //Umple fulgul
    }
}

int pufulet(int x,int y)
{
    if(x<=180&&x>=120&&y<=230&&y>=170)
    {
        punct A, B, C;
        A.x = getmaxx()/2-l/2; A.y = getmaxy()/2+l*sqrt(3)/6;
        B.x = getmaxx()/2+l/2; B.y = A.y;
        C = punct_mij(B, A);
        iteratii=2;
        koch_snowflake(A,B,C);
        return 1;
    }
    return 0;
}
int pufulet2(int x,int y)
{
    if(x<=180&&x>=120&&y<=430&&y>=370)
    {
        punct A, B, C;
        A.x = getmaxx()/2-l/2; A.y = getmaxy()/2+l*sqrt(3)/6;
        B.x = getmaxx()/2+l/2; B.y = A.y;
        C = punct_mij(B, A);
        iteratii=3;
        koch_snowflake(A,B,C);
        return 1;
    }
    return 0;
}
int pufulet3(int x,int y)
{
    if(x<=180&&x>=120&&y<=630&&y>=570)
    {
        punct A, B, C;
        A.x = getmaxx()/2-l/2; A.y = getmaxy()/2+l*sqrt(3)/6;
        B.x = getmaxx()/2+l/2; B.y = A.y;
        C = punct_mij(B, A);
        iteratii=4;
        koch_snowflake(A,B,C);
        return 1;
    }
    return 0;
}

void text()
{
    setcolor(CYAN);
    settextstyle(7,1,4);
    outtextxy(50,50,"Ein Proiekt von");
    settextstyle(5,0,6);
    outtextxy(450,55,"Andreea Comsa");
}
void ploaie(int x)
{
int j;

int i,rx,ry;
for(i=0;i<800;i++)
{
setcolor(rand()%10);
 rx=rand()%1200;
 ry=rand()%700;
 for(j=1;j<100;j++)
 line(rx+1,ry+1,rx+0.5,ry+4);
 }
}
int main()
{
    initwindow(1200,700,"Stickman");
    int x1,y1,x,y;
    x1=x=700;
    y1=y=200;
    stickman(x1,y1);
    dinge(150,200,30);
    text();
    int a;
do
{
    a=getch();
    switch(a)
    {

        case KEY_LEFT:
            {
                cleardevice();
                x1-=10;
                stickman(x1,y1);
                break;
            }
        case KEY_RIGHT:
            {
                cleardevice();
                x1+=10;
                stickman(x1,y1);

                break;
            }
            case KEY_UP:
            {
                cleardevice();
                y1-=10;
                stickman(x1,y1);
                break;
            }
        case KEY_DOWN:
            {
                cleardevice();
                y1+=10;
                stickman(x1,y1);
                break;
            }
        stickman(x1,y1);
    }
    dinge(150,200,30);
    delay(5);
    text();
    setcolor(RED);
    if(pufulet(x1,y1))
    {   delay(1500);
        cleardevice();
        x1+=200;
        stickman(x1,y1);
        dinge(150,200,30);
        text();
    }
    setcolor(GREEN);
    if(pufulet2(x1,y1))
    {   delay(1300);
        cleardevice();
        x1+=200;
        stickman(x1,y1);
        dinge(150,200,30);
        text();
    }
    setcolor(YELLOW);
    if(pufulet3(x1,y1))
        {   delay(1100);
            cleardevice();
            x1+=200;
            stickman(x1,y1);
            dinge(150,200,30);
            text();
        }
}while(a!=' ');
    cleardevice();
    x+=200;y+=50;
    stickman(x,y);
    x-=520;
    stickman(x,y);
    text();
    setcolor(MAGENTA);
    settextstyle(8,0,10);
    outtextxy(850,400,"ENDE!");
    ploaie(300);
    getch();
    closegraph();

    return 0;
}

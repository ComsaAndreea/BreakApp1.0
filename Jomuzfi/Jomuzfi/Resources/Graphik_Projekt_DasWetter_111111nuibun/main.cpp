#include <iostream>
#include <fstream>
#include <graphics.h>
#include <string.h>
#include <stdlib.h>
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

void treppen()
{
        int x1=220,x2=71,ct=0,y=550,l=0;
    setcolor(YELLOW);
    line(990,193,990,600);
    line(940,193,990,193);
    for (int x=171;x<=700;x+=71)
    {
        if(ct%2==0)
        {
            setcolor(CYAN);
            rectangle(x+30,y+50,590+l,y);
            circle(1035-x2,x1,20);
            setfillstyle(SOLID_FILL,CYAN);
            floodfill(1035-x2,x1,CYAN);
            l=l+50;
        }
        else
        {
            setcolor(YELLOW);
            rectangle(x+30,y+50,590+l,y);
            circle(1035-x2,x1,20);
            setfillstyle(SOLID_FILL,YELLOW);
            floodfill(1035-x2,x1,YELLOW);
            l=l+50;
        }
        x1+=51;y-=51;
        ct++;
    }

}
void nori()
{
    setcolor(CYAN);
    int y=50;
    for(int x=0;x<=1000;x+=50)
    {
        circle(x,y,50);
        setfillstyle(SOLID_FILL,CYAN);
        floodfill(x,y,CYAN);
        delay(200);
    }
}

void soare()
{
    int x=120, y=200, r=40;
    setcolor(YELLOW);
    circle(x,y,r);
    setfillstyle(SOLID_FILL,YELLOW);
    floodfill(x,y,YELLOW);
    line(x+60,y,x+100,y);
    line(x-60,y,x-100,y);
    line(x,y+60,x,y+100);
    line(x,y-60,x,y-100);
    line(x+40,y+40,x+70,y+70);
    line(x+40,y-40,x+70,y-70);
    line(x-40,y-40,x-70,y-70);
    line(x-40,y+40,x-70,y+70);
}
void ecran(int x)
{
setcolor(WHITE);
int i,rx,ry;
while(rx=rand()%1200)
 {soare();
 setcolor(rand()%12);
     rx=rand()%1200;
 ry=rand()%700;
 line(rx+1,ry+1,rx+0.5,ry+4);
}
}
void intrebare(int i)
{
    char a[9][500]={"","WELCHE IST DIE PRIMZAHL:159,441 ODER 773 (IN WORTEN BITTE ANTWORTEN)","WAS IST GESUNDER: GEWINN ODER FREUDE?                                                                                ","WER IST DER ERSTE PRASIDENT DER USA?(NACHNAME)                                                                   ","GIB EIN SYNONYM ZU: SENECTUTE                                                                                   ",    "WELCHER IST DER LETZTE SOMMERMONAT                                                ","WELCHE IST DIE HAUPTSTADT VON ISLAND?                                             ","ABER DIE HAUPTSTADT VON GRIECHENLAND?                                                              ","DIE HAUPTSTADT VON ÄGYPTEN IST...?                                                                ",};
    settextstyle(TRIPLEX_FONT,HORIZ_DIR,110);
    outtextxy(50,30,a[i]);

}
void gehenstick(int &x,int &y, int j)
{
    for(int i=1;i<=6;i++)
    {
        stickman(x,y);
        delay(100);
        y-=7;
        x+=18;
        delay(100);
        cleardevice();
        treppen();
        intrebare(j);
    }
    treppen();
    stickman(x,y);
}
void ploaie(int x)
{
int j;
setcolor(WHITE);
int i,rx,ry;
for(i=0;i<400;i++)
{
 rx=rand()%1200;
 ry=rand()%700;
 for(j=1;j<100;j++)
 line(rx+1,ry+1,rx+0.5,ry+4);
 }
}



void citireRaspcorect(char r[100][100])
{
    ifstream f("input.txt");
    for(int i=1;i<=8;i++)
        f>>r[i];
}

void answear(char r[100][100],int i,int &x,int &y,int &ok)
{
    char deineAntw[100][100];
    ok=0;
    cin>>deineAntw[i];
    if(strcmp(deineAntw[i],r[i])==0)
    {
        gehenstick(x,y,i);
        ok=1;
        soare();
     }
    else    {cout<<"nein\n";nori();ploaie(x);}
}

int main()
{
    initwindow(1000,600);
    int x=120,y=461,ok=0;
    char r[100][100];
    citireRaspcorect(r);
    stickman(x,y);
    treppen();
    for(int i=1;i<=8;i++)
    {
        intrebare(i);
        y-=12;
        answear(r,i,x,y,ok);
    }
    cleardevice();
    x-=25;
    stickman(x,y);
    treppen();
    ecran(x);
    getch();
    return 0;
}

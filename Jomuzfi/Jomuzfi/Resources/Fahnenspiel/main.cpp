#include <iostream>
#include <graphics.h>
#include <conio.h>
#include <stdio.h>

using namespace std;

int st[100],n,p,punkt=0;
int farben[8]={0,0,1,2,4,12,14,15};
char pkt[20],po[2];

void primaculoare(int x)
{
    //ERSTE FARBE (LINKS)
    setcolor(25);
    setfillstyle(SOLID_FILL,x);
    rectangle(81,70,181,300);
    floodfill(82, 82, 25);
}
void adouaculoare(int x)
{
    //ZWEITE FARBE (MITTE)
    setcolor(25);
    setfillstyle(SOLID_FILL,x);
    rectangle(182,70,282,300);
    floodfill(200, 82, 25);
}
void atreiaculoare(int x)
{
    //DRITTE FARBE (RECHTS)
    setcolor(25);
    setfillstyle(SOLID_FILL,x);
    rectangle(282,70,383,300);
    floodfill(300, 82, 25);
}
void RAMA()
{
    //RAHMEN
    //LINKS
    for(int i=1;i<30;i++)
    {
        setcolor(LIGHTRED);
        setfillstyle(SOLID_FILL,LIGHTRED);
        circle(20,20*i,5);
        floodfill(20,20*i,LIGHTRED);
    }
    //OBEN
    for(int i=2;i<40;i++)
    {
        setcolor(LIGHTRED);
        setfillstyle(SOLID_FILL,LIGHTRED);
        circle(20*i,20,5);
        floodfill(20*i,20,LIGHTRED);
    }
    //UNTEN
    for(int i=2;i<40;i++)
    {
        setcolor(LIGHTRED);
        setfillstyle(SOLID_FILL,LIGHTRED);
        circle(20*i,580,5);
        floodfill(20*i,580,LIGHTRED);
    }
    //RECHTS
    for(int i=2;i<29;i++)
    {
        setcolor(LIGHTRED);
        setfillstyle(SOLID_FILL,LIGHTRED);
        circle(780,20*i,5);
        floodfill(780,20*i,LIGHTRED);
    }
}
void zeichnen()
{
    //HINTERGRUND
    setcolor(LIGHTBLUE);
    setfillstyle(SOLID_FILL,LIGHTBLUE);
    floodfill(1, 1, LIGHTBLUE);
    //FAHNENSTOCK
    setcolor(BLACK);
    setfillstyle(SOLID_FILL,BLACK);
    rectangle(70,70,80,570);
    floodfill(75, 75, BLACK);
    RAMA();
    //ANLEINTUNGEN; TEXT
    setcolor(BLACK);
    setbkcolor(LIGHTBLUE);
    settextstyle(BOLD_FONT,0,2);
    outtextxy(425,40,"Press anywhere to start!");
    outtextxy(425,60,"Instructions:");
    outtextxy(425,80,"Press any letter to stop");
    outtextxy(425,100,"the movement of the flags.");
    outtextxy(425,120,"if( flag exists )");
    outtextxy(425,140,"=> you get a point :)");
    outtextxy(425,160,"else");
    outtextxy(425,180,"=> you lose a point :(");
    outtextxy(425,200,"Press Spacebar to continue.");
    //PUNKTE
    settextstyle(BOLD_FONT,0,3);
    setcolor(LIGHTMAGENTA);
    setbkcolor(BLACK);
    sprintf(pkt, "Points: %d",punkt);
    outtextxy(500,475,pkt);
    primaculoare(9);
    adouaculoare(9);
    atreiaculoare(9);
}
void richtig_geantwortet (int x, int y, int z)
{
    //FUNKTION FUR DAS TESTEN OB DIE RICHTIGE FAHNE GEWAHLT WURDE
    settextstyle(BOLD_FONT,0,3);
    setcolor(LIGHTMAGENTA);
    setbkcolor(BLACK);
    if(farben[x]==0&&farben[y]==14&&farben[z]==4)
        {
            outtextxy(475,400,"     BELGIEN    ");
            punkt++;
        }
    else if(farben[x]==1&&farben[y]==14&&farben[z]==4)
        {
            outtextxy(475,400,"    RUMANIEN    ");
            punkt++;
        }
    else if(farben[x]==12&&farben[y]==15&&farben[z]==2)
        {
            outtextxy(475,400,"COASTA DE FILDES");
            punkt++;
        }
    else if(farben[x]==1&&farben[y]==15&&farben[z]==4)
        {
            outtextxy(475,400,"   FRANKREICH   ");
            punkt++;
        }
    else if(farben[x]==4&&farben[y]==14&&farben[z]==2)
        {
            outtextxy(475,400,"     GUINEEA    ");
            punkt++;
        }
    else if(farben[x]==2&&farben[y]==15&&farben[z]==12)
        {
            outtextxy(475,400,"     IRLAND     ");
            punkt++;
        }
    else if(farben[x]==2&&farben[y]==15&&farben[z]==4)
        {
            outtextxy(475,400,"     ITALIEN    ");
            punkt++;
        }
    else if(farben[x]==2&&farben[y]==14&&farben[z]==4)
        {
            outtextxy(475,400,"      MALI      ");
            punkt++;
        }
    else if(farben[x]==2&&farben[y]==15&&farben[z]==2)
        {
            outtextxy(475,400,"     NIGERIA    ");
            punkt++;
        }
    else
        if(punkt>0)
            punkt--;
}
void ploaie()
{
    //KONFETTI-REGEN AM ENDE
    int j;
    int i,rx,ry;
    for(i=0;i<400;i++)
    {
        rx=rand()%1200;
        ry=rand()%700;
        for(j=1;j<100;j++)
        {
            setcolor(rand()%15);
            line(rx+1,ry+1,rx+0.5,ry+4);
        }
    }
}
//BACKTRACKING-METHODE
int valid(int k)
{
    if(k>2)
        if(st[2]==st[3] || st[2]==st[1])    //NICHT DIE GLEICHE FARBE NEBENEINANDER
            return 0;
    return 1;
}
int sol(int k)
{
    return k==p;
}
void tipar(int k)
{
    cout<<farben[st[1]]<<' '<<farben[st[2]]<<' '<<farben[st[3]];
    primaculoare(farben[st[1]]);
    adouaculoare(farben[st[2]]);
    atreiaculoare(farben[st[3]]);
    delay(1000);
    //TESTEN OB DIE FAHNE DIE LETZTEN FARBEN ERREICHT HAT => ENDE
    if(st[1]==7 && st[2]==6 &&st[3]==7)
    {
        //ENDSEITE
        cleardevice();
        RAMA();
        settextstyle(BOLD_FONT,0,4);
        setcolor(YELLOW);
        outtextxy(250,250,"Game over!");
        if(punkt>7)
            outtextxy(180,300,"You are an expert! :)");
        else if(punkt>3)
            outtextxy(180,300,"You are advanced!");
        else if(punkt>0)
            outtextxy(180,300,"You are a beginner!");
        else if(punkt==0)
            outtextxy(180,300,"You have to work more!");
        outtextxy(150,350,"You've got ");
        sprintf(po,"%d",punkt);
        outtextxy(360,350,po);
        outtextxy(390,350," Points");
        outtextxy(550, 350, "out of 9!");
        settextstyle(BOLD_FONT,0,2);
        outtextxy(200,75,"(Press r to replay) || (Press x to exit)");
        ploaie();
    }
    else if(kbhit())
    {
        //TESTET OB DIE FAHNE RICHTIG GEWAHLT WURDE
        richtig_geantwortet(st[1],st[2],st[3]);
        cout<<'\n'<<punkt<<'\n';
        //ANSCHREIBEN DER PUNKTE
        sprintf(pkt, "Points: %d",punkt);
        outtextxy(500,475,pkt);
        //WARTEN BIS DER SPIELER SPACEBAR CLICKT, UM DAS SPIEL WEITER ZU GEHEN.
        while(1)
        {
            if(getch()==32)
            {
                setcolor(LIGHTBLUE);
                setbkcolor(LIGHTBLUE);
                //LOSCHEN DES LANDES
                outtextxy(475,400,"                ");
                break;
            }
        }
    }
    cout<<'\n';
}
void backtracking(int k)
{
    for(int i=1;i<=n;i++)
    {
        st[k]=i;
        if(valid(k))
            if(sol(k))
                tipar(k);
            else
                backtracking(k+1);
    }
}
//DIE PLAY UND REPLAY FUNKTION
void mainul()
{
    cleardevice();
    punkt=0;
    zeichnen();
    n=7,p=3;
    getch();
    backtracking(1);
}
int main()
{
    initwindow(800,600,"Fahnenspiel");
    mainul();
    while(getch()==114) //"r" TASTE WURDE GECLICKT => REPLAY
    {
        mainul();
        if(getch()==120)//"x" TASTE WURDE GECLICKT => DAS SPIEL ENDET
            return 0;
    }
}

import greenfoot.*;  // (World, Actor, GreenfootImage, Greenfoot and MouseInfo)

/**
 * Write a description of class fundal2 here.
 * 
 * @author (your name) 
 * @version (a version number or a date)
 */
public class fundal2 extends World
{

    /**
     * Constructor for objects of class fundal2.
     * 
     */
    public fundal2()
    {    
        // Create a new world with 600x400 cells with a cell size of 1x1 pixels.
        super(600, 400, 1); 
        prepare();
    }
     
    private void prepare()
    {

        crab crab = new crab();
        addObject(crab,57,59);
        rac rac = new rac();
        addObject(rac,235,49);
        rac rac2 = new rac();
        addObject(rac2,74,182);
        rac rac3 = new rac();
        addObject(rac3,248,175);
        rac rac4 = new rac();
        addObject(rac4,406,110);
        rac rac5 = new rac();
        addObject(rac5,410,249);
        rac rac6 = new rac();
        addObject(rac6,244,327);
        rac rac7 = new rac();
        addObject(rac7,26,379);
        rac rac8 = new rac();
        addObject(rac8,556,31);
        rac rac9 = new rac();
        addObject(rac9,556,368);
        worm worm = new worm();
        addObject(worm,530,206);
        worm worm2 = new worm();
        addObject(worm2,353,184);
        worm worm3 = new worm();
        addObject(worm3,332,296);
        worm worm4 = new worm();
        addObject(worm4,445,334);
        worm worm5 = new worm();
        addObject(worm5,92,294);
        worm worm6 = new worm();
        addObject(worm6,366,40);
        worm worm7 = new worm();
        addObject(worm7,551,95);
        worm worm8 = new worm();
        addObject(worm8,174,121);
        worm worm9 = new worm();
        addObject(worm9,170,241);
        worm worm10 = new worm();
        addObject(worm10,160,372);
        worm worm11 = new worm();
        addObject(worm11,383,362);
        worm worm12 = new worm();
        addObject(worm12,543,289);
        worm worm13 = new worm();
        addObject(worm13,456,182);
        worm worm14 = new worm();
        addObject(worm14,471,78);
        worm worm15 = new worm();
        addObject(worm15,132,32);
        rac3.setLocation(257,149);
        rac4.setLocation(425,77);
        worm6.setLocation(336,93);
        worm14.setLocation(539,124);
        rac5.setLocation(411,297);
        worm11.setLocation(326,349);
        rac5.setLocation(424,291);
        worm4.setLocation(480,227);
        worm4.setLocation(406,385);
        worm10.setLocation(129,361);
        worm8.setLocation(153,132);
        rac3.setLocation(274,157);
        worm6.setLocation(395,176);
        rac4.setLocation(362,58);
        worm6.setLocation(477,88);
    }

    public void act()
    {
        if(getObjects(worm.class).isEmpty())
        {
            Greenfoot.playSound("fanfare.wav");
            Greenfoot.stop();
        }
    }
        
}

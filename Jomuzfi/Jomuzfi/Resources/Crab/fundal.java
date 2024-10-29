import greenfoot.*;  // (World, Actor, GreenfootImage, Greenfoot and MouseInfo)

/**
 * Write a description of class fundal here.
 * 
 * @author (your name) 
 * @version (a version number or a date)
 */
public class fundal extends World
{

    /**
     * Constructor for objects of class fundal.
     * 
     */
    public fundal()
    {    
        // Create a new world with 600x400 cells with a cell size of 1x1 pixels.
        super(600, 400, 1); 
        prepare();
    }

    /**
     * Prepare the world for the start of the program.
     * That is: create the initial objects and add them to the world.
     */
    private void prepare()
    {
        crab crab = new crab();
        addObject(crab,309,157);
        rac rac = new rac();
        addObject(rac,435,245);
        rac rac2 = new rac();
        addObject(rac2,432,61);
        rac rac3 = new rac();
        addObject(rac3,158,91);
        rac rac4 = new rac();
        addObject(rac4,130,266);
        worm worm = new worm();
        addObject(worm,247,256);
        worm worm2 = new worm();
        addObject(worm2,314,73);
        worm worm3 = new worm();
        addObject(worm3,80,137);
        worm worm4 = new worm();
        addObject(worm4,514,156);
        worm worm6 = new worm();
        addObject(worm6,500,166);
        worm worm5 = new worm();
        addObject(worm5,443,348);
        rac rac5 = new rac();
        addObject(rac5,253,332);
    }
    public void act()
    {
        if(getObjects(worm.class).isEmpty())
        {
            Greenfoot.playSound("fanfare.wav");
            Greenfoot.delay(300);
            Greenfoot.setWorld(new fundal2());
        }
    
    }
}

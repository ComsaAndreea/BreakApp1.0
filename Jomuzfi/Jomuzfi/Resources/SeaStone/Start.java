import greenfoot.*;  // (World, Actor, GreenfootImage, Greenfoot and MouseInfo)

/**
 * Write a description of class Start here.
 * 
 * @author (your name) 
 * @version (a version number or a date)
 */
public class Start extends World
{

    /**
     * Constructor for objects of class Start.
     * 
     */
    private int counter;
    GreenfootSound music = new GreenfootSound("fluier.wav");
    public Start()
    {    
        // Create a new world with 600x400 cells with a cell size of 1x1 pixels.
        super(800, 600, 1); 
        music.play();
        act();
    }
    public void act()
    {
        if (Greenfoot.mouseClicked(this)) 
        {
            Greenfoot.setWorld(new Level_1());
            music.stop();
        }
    }
        // getWorld().showText("Sea Stone", 400,200);
        // getWorld().showText("Start", 400,400);
}

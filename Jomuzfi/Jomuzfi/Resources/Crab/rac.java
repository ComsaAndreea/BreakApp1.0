import greenfoot.*;  // (World, Actor, GreenfootImage, Greenfoot and MouseInfo)

/**
 * Write a description of class rac here.
 * 
 * @author (your name) 
 * @version (a version number or a date)
 */
public class rac extends Actor
{
    /**
     * Act - do whatever the rac wants to do. This method is called whenever
     * the 'Act' or 'Run' button gets pressed in the environment.
     */
    public void act() 
    {
        // Add your action code here.
        turnAtEdge();
        lookForCrab();
    }    
    public void turnAtEdge()
    {
        if(isAtEdge())
            turn(17);
    }
    public void randomTurn()
    {
        if (Greenfoot.getRandomNumber(100)>90)
            turn(Greenfoot.getRandomNumber(90)-45);
    }
    
    public void lookForCrab()
    {
        if(isTouching(crab.class))
        {
            removeTouching(crab.class);
            Greenfoot.playSound("au.wav");
            Greenfoot.setWorld(new fundal());
        }
    }
    
    
    
}

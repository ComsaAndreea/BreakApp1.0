import greenfoot.*;  // (World, Actor, GreenfootImage, Greenfoot and MouseInfo)

/**
 * Write a description of class liftopen here.
 * 
 * @author (your name) 
 * @version (a version number or a date)
 */
public class liftopen extends Lift
{
    /**
     * Act - do whatever the liftopen wants to do. This method is called whenever
     * the 'Act' or 'Run' button gets pressed in the environment.
     */
    public void act() 
    {
        Actor PersonStern= getOneObjectAtOffset(0,0,PersonStern.class);
        Actor Stein= getOneObjectAtOffset(0,0,Stein.class);
        Actor liftclosed= getOneObjectAtOffset(0,0,liftclosed.class);
        if(PersonStern != null && Stein != null)
          {
            removeTouching(liftclosed.class);
            Greenfoot.playSound("fanfare.wav");  
            Greenfoot.delay(200);
            removeTouching(PersonStern.class);
            removeTouching(Stein.class);
          }
        
        
    }    
}

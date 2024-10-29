import greenfoot.*;  // (World, Actor, GreenfootImage, Greenfoot and MouseInfo)

/**
 * Write a description of class crab here.
 * 
 * @author (your name) 
 * @version (a version number or a date)
 */
public class crab extends Actor
{
    /**
     * Act - do whatever the crab wants to do. This method is called whenever
     * the 'Act' or 'Run' button gets pressed in the environment.
     */
    private GreenfootImage image1;
    private GreenfootImage image2;
    private int wormsEaten;
    
    public crab()
    {
        image1=new GreenfootImage("crab.png");
        image2=new GreenfootImage("crab2.png");
        setImage(image1);
    }
    
    public void act() 
    {
        checkKeypress();
        lookForWorm();

    } 
    
    public void swichImage()
    {
        if(getImage()==image1)
        {
            setImage(image2);
            swichImage();
        }
        else
        {    
            setImage(image1);
            swichImage();
        }
    }
    public void checkKeypress()
    {
        int y=getY();
        int x=getX();
        if(Greenfoot.isKeyDown("left"))
            x-=4;
        if(Greenfoot.isKeyDown("right"))
            x+=4;
        if(Greenfoot.isKeyDown("up"))
        {
            y-=4;
        }
            
        if(Greenfoot.isKeyDown("down"))
        {
            y+=4;
        }
        setLocation(x,y);
    }
    public void lookForWorm()
    {
        if(isTouching(worm.class))
        {
            removeTouching(worm.class);
            Greenfoot.playSound("slurp.wav");
        }
    }
}

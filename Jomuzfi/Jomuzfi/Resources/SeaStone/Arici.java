import greenfoot.*;  // (World, Actor, GreenfootImage, Greenfoot and MouseInfo)

/**
 * Write a description of class Arici here.
 * 
 * @author (your name) 
 * @version (a version number or a date)
 */
public class Arici extends Personaje
{
    /**
     * Act - do whatever the Arici wants to do. This method is called whenever
     * the 'Act' or 'Run' button gets pressed in the environment.
     */
    
      public Arici(int width,int height)
     {
        GreenfootImage image = getImage();
        image.scale(width, height);
        setImage(image);
     } 
    public void act() 
    {
        // Add your action code here.
    }    
}

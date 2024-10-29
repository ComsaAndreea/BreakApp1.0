import greenfoot.*;  // (World, Actor, GreenfootImage, Greenfoot and MouseInfo)

/**
 * Write a description of class butoi here.
 * 
 * @author (your name) 
 * @version (a version number or a date)
 */
public class butoi extends DeLuat
{
    /**
     * Act - do whatever the butoi wants to do. This method is called whenever
     * the 'Act' or 'Run' button gets pressed in the environment.
     */
     public butoi()
 {
     this(60,40);
 }
  public butoi(int width, int height)
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

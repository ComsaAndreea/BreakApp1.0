import greenfoot.*;  // (World, Actor, GreenfootImage, Greenfoot and MouseInfo)

/**
 * Write a description of class Placa here.
 * 
 * @author (your name) 
 * @version (a version number or a date)
 */
public class Placa extends Baze
{
         public Placa()
 {
     this(700,16);
 }
    
    public Placa(int width, int height)
    {
        GreenfootImage image = getImage();
        image.scale(width, height);
        setImage(image);
    act();
}

    public void act() 
    {
        //while(Placa != 0)
    }    
}

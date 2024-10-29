import greenfoot.*;  // (World, Actor, GreenfootImage, Greenfoot and MouseInfo)

/**
 * Write a description of class Stein here.
 * 
 * @author (your name) 
 * @version (a version number or a date)
 */
public class Stein extends Personaje
{
     private int gravity = 1;//
     private final int Schritt = 3;
     private int geschwind;
     private int ct=0;
     public Stein(int width,int height)
     {
        geschwind = 0;
        GreenfootImage image = getImage();
        image.scale(width, height);
        setImage(image);
     } 

    public void act() 
    {
        int ct=5;
        fallen();
        if(Greenfoot.isKeyDown("up")&&isOnSolidGround()||isOnSolidGround2()) jump();
        move();
        eatButoi();
        eatGreenf();
        Aricihit();
        //getWorld().showText("WIN", 400,400);
    }
    public void eatButoi()
    {
        Actor butoi= getOneObjectAtOffset(0,0,butoi.class);
        if(butoi != null)
          {
            removeTouching(butoi.class);
            Greenfoot.playSound("slurp.wav");   
          }
    } 
     public void eatGreenf()
    {
        Actor greenf= getOneObjectAtOffset(0,0,greenf.class);
        if(greenf != null)
          {
            removeTouching(greenf.class);
            starS();
          }
    }
    public void Aricihit()
    {
        Actor Arici= getOneObjectAtOffset(0,0,Arici.class);
        if(Arici != null)
          {
            Greenfoot.playSound("au.wav");
            jump();
          }
    } 

    public void fallen()
    {
        setLocation(getX(), getY() + geschwind);
        if(isOnSolidGround()||isOnSolidGround2())
        {
            geschwind=0;
            while(isOnSolidGround()||isOnSolidGround2())
                setLocation(getX(), getY() - 1);
            setLocation(getX(), getY() + 1);
        }
        else if(geschwind < 0 && didBumpHead() )
        {
            geschwind=0;
            while(didBumpHead() )
                setLocation(getX(), getY() + 1);
        }
        else geschwind += gravity;
    }


    public void jump()
    {
        geschwind = -13;
        Greenfoot.playSound("jump.wav");
    }
    public void move()
    {
        int y = getY();
        int x = getX();
        if(Greenfoot.isKeyDown("left")&&canMoveLeft())
        {
            x -= Schritt;
            turn(-15);
        }
        if(Greenfoot.isKeyDown("right")&&canMoveRight() )
        {
            x += Schritt;
            turn(15);
        }
        setLocation(x, y);
    }
    
    public boolean isOnSolidGround()
    {
        boolean isOnGround = false;
        if(getY() > getWorld().getHeight() - 50)
            isOnGround = true;
        int imageWidth = getImage().getWidth();
        int imageHeight = getImage().getHeight();
        
        if(getOneObjectAtOffset(imageWidth / -2, imageHeight / 2, Placa.class) != null || getOneObjectAtOffset(imageWidth / 2, imageHeight / 2, Placa.class) != null)
            isOnGround = true;
        return isOnGround;
    }
    
     public boolean didBumpHead()
    {
        boolean bumpedHead = false;
        int imageWidth = getImage().getWidth();
        int imageHeight = getImage().getHeight();
        
        if(getOneObjectAtOffset(imageWidth / -2, imageHeight / -2, Placa.class) != null ||
        getOneObjectAtOffset(imageWidth / 2, imageHeight / -2, Placa.class) != null)
            bumpedHead = true;
        return bumpedHead;
    }
     public boolean canMoveLeft()
    {
        boolean canMoveLeft = true;
        int imageWidth = getImage().getWidth();
        int imageHeight = getImage().getHeight();
        
        if(getOneObjectAtOffset(imageWidth / -2 - Schritt, imageHeight / -2, Placa.class) != null ||
        getOneObjectAtOffset(imageWidth / -2 - Schritt, imageHeight / 2 - 1, Placa.class) != null)
           canMoveLeft = false;
        return canMoveLeft;
    }
    public boolean canMoveRight()
    {
        boolean canMoveLeft = true;
        int imageWidth = getImage().getWidth();
        int imageHeight = getImage().getHeight();
        
        if(getOneObjectAtOffset(imageWidth / 2 + Schritt, imageHeight / -2, Placa.class) != null ||
        getOneObjectAtOffset(imageWidth / 2 + Schritt, imageHeight / 2 - 1, Placa.class) != null)
           canMoveLeft = false;
        return canMoveLeft;
    }
    public boolean isOnSolidGround2()
    {
        boolean isOnGround = false;
        if(getY() > getWorld().getHeight() - 50)
            isOnGround = true;
        int imageWidth = getImage().getWidth();
        int imageHeight = getImage().getHeight();
        
        if(getOneObjectAtOffset(imageWidth / -2, imageHeight / 2, Basis.class) != null || getOneObjectAtOffset(imageWidth / 2, imageHeight / 2, Basis.class) != null)
            isOnGround = true;
        return isOnGround;
    }
    
     public boolean didBumpHead2()
    {
        boolean bumpedHead = false;
        int imageWidth = getImage().getWidth();
        int imageHeight = getImage().getHeight();
        
        if(getOneObjectAtOffset(imageWidth / -2, imageHeight / -2, Basis.class) != null ||
        getOneObjectAtOffset(imageWidth / 2, imageHeight / -2, Basis.class) != null)
            bumpedHead = true;
        return bumpedHead;
    }
     public boolean canMoveLeft2()
    {
        boolean canMoveLeft = true;
        int imageWidth = getImage().getWidth();
        int imageHeight = getImage().getHeight();
        
        if(getOneObjectAtOffset(imageWidth / -2 - Schritt, imageHeight / -2, Basis.class) != null ||
        getOneObjectAtOffset(imageWidth / -2 - Schritt, imageHeight / 2 - 1, Basis.class) != null)
           canMoveLeft = false;
        return canMoveLeft;
    }
    public boolean canMoveRight2()
    {
        boolean canMoveLeft = true;
        int imageWidth = getImage().getWidth();
        int imageHeight = getImage().getHeight();
        
        if(getOneObjectAtOffset(imageWidth / 2 + Schritt, imageHeight / -2, Basis.class) != null ||
        getOneObjectAtOffset(imageWidth / 2 + Schritt, imageHeight / 2 - 1, Basis.class) != null)
           canMoveLeft = false;
        return canMoveLeft;
    }
        public void starS()
           {
               GreenfootImage myImage = getImage();
               int myNewHeight = (int)myImage.getHeight()/2;
               int myNewWidth = (int)myImage.getWidth()/2;
               myImage.scale(myNewWidth, myNewHeight);
           }
                   public void starB()
           {
               GreenfootImage myImage = getImage();
               int myNewHeight = (int)myImage.getHeight()*2;
               int myNewWidth = (int)myImage.getWidth()*2;
               myImage.scale(myNewWidth, myNewHeight);
           }
    }

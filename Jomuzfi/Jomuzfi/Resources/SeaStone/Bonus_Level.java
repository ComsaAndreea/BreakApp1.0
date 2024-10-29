import greenfoot.*;  // (World, Actor, GreenfootImage, Greenfoot and MouseInfo)

/**
 * Write a description of class MyWorld1 here.
 * 
 * @author (your name) 
 * @version (a version number or a date)
 */

public class Bonus_Level extends World
{
    GreenfootSound music = new GreenfootSound("Rowing.wav");
    public Bonus_Level()
    {   
        // Create a new world with 600x400 cells with a cell size of 1x1 pixels.
        super(800, 600, 1);
        prepare();
        started();
    }
   
    public void started()
    {
            music.playLoop();
    }

    /**
     * Prepare the world for the start of the program.
     * That is: create the initial objects and add them to the world.
     */
    private void prepare()
    {
        Basis basis = new Basis(801, 35);
        addObject(basis,494,451);
        basis.setLocation(399,582);
        Placa placa = new Placa(400, 16);
        addObject(placa,212,501);
        placa.setLocation(200,498);
        Placa placa2 = new Placa();
        addObject(placa2,494,420);
        Placa placa3 = new Placa();
        addObject(placa3,494,420);
        Placa placa4 = new Placa();
        addObject(placa4,330,344);
        Placa placa5 = new Placa();
        addObject(placa5,541,269);
        Placa placa6 = new Placa();
        addObject(placa6,365,201);
        placa.setLocation(172,448);
        placa3.setLocation(349,497);
        placa.setLocation(241,117);
        placa6.setLocation(362,191);
        placa5.setLocation(449,268);
        placa.setLocation(338,123);
        Placa placa7 = new Placa();
        addObject(placa7,311,108);
        placa.setLocation(393,53);
        Basis basis2 = new Basis(50, 16);
        addObject(basis2,431,400);
        basis2.setLocation(67,297);
        basis2.setLocation(67,300);
        liftopen liftopen = new liftopen();
        addObject(liftopen,47,73);
        liftopen.setLocation(40,66);
        liftclosed liftclosed = new liftclosed();
        addObject(liftclosed,46,74);
        liftclosed.setLocation(39,67);
        basis2.setLocation(59,301);
        placa5.setLocation(450,259);
        placa6.setLocation(345,180);
        placa7.setLocation(352,109);
        Basis basis3 = new Basis(55, 16);
        addObject(basis3,618,389);
        basis3.setLocation(766,157);
        Basis basis4 = new Basis(60, 16);
        addObject(basis4,565,406);
        basis4.setLocation(71,441);
        Placa placa8 = new Placa();
        addObject(placa8,405,563);
        placa8.setLocation(347,558);
        placa3.setLocation(349,503);
        placa3.setLocation(348,499);
        placa8.setLocation(347,566);
        basis4.setLocation(79,441);
        butoi butoi = new butoi();
        addObject(butoi,190,542);
        butoi butoi2 = new butoi();
        addObject(butoi2,556,545);
        butoi butoi3 = new butoi();
        addObject(butoi3,418,470);
        butoi butoi4 = new butoi();
        addObject(butoi4,177,478);
        butoi butoi5 = new butoi();
        addObject(butoi5,284,392);
        butoi butoi6 = new butoi();
        addObject(butoi6,72,421);
        butoi butoi7 = new butoi();
        addObject(butoi7,181,332);
        butoi butoi8 = new butoi();
        addObject(butoi8,75,287);
        butoi butoi9 = new butoi();
        addObject(butoi9,258,234);
        butoi butoi10 = new butoi();
        addObject(butoi10,337,160);
        butoi butoi11 = new butoi();
        addObject(butoi11,113,158);
        butoi butoi12 = new butoi();
        addObject(butoi12,245,84);
        butoi butoi13 = new butoi();
        addObject(butoi13,438,20);
        butoi butoi14 = new butoi();
        addObject(butoi14,601,87);
        butoi butoi15 = new butoi();
        addObject(butoi15,678,153);
        butoi butoi16 = new butoi();
        addObject(butoi16,768,222);
        butoi butoi17 = new butoi();
        addObject(butoi17,781,124);
        butoi butoi18 = new butoi();
        addObject(butoi18,749,503);
        butoi butoi19 = new butoi();
        addObject(butoi19,630,319);
        anchor anchor = new anchor();
        addObject(anchor,653,538);
        anchor anchor2 = new anchor();
        addObject(anchor2,371,543);
        anchor anchor3 = new anchor();
        addObject(anchor3,355,477);
        anchor anchor4 = new anchor();
        addObject(anchor4,125,533);
        anchor anchor5 = new anchor();
        addObject(anchor5,527,457);
        anchor anchor6 = new anchor();
        addObject(anchor6,600,361);
        anchor anchor7 = new anchor();
        addObject(anchor7,798,354);
        anchor anchor8 = new anchor();
        addObject(anchor8,463,310);
        anchor anchor9 = new anchor();
        addObject(anchor9,40,222);
        anchor anchor10 = new anchor();
        addObject(anchor10,206,152);
        anchor anchor11 = new anchor();
        addObject(anchor11,125,61);
        anchor anchor12 = new anchor();
        addObject(anchor12,322,21);
        anchor anchor13 = new anchor();
        addObject(anchor13,479,85);
        anchor anchor14 = new anchor();
        addObject(anchor14,663,22);
        anchor anchor15 = new anchor();
        addObject(anchor15,740,114);
        anchor anchor16 = new anchor();
        addObject(anchor16,596,154);
        anchor anchor17 = new anchor();
        addObject(anchor17,533,230);
        anchor anchor18 = new anchor();
        addObject(anchor18,129,394);
        removeObject(butoi15);
        removeObject(butoi7);
        anchor8.setLocation(295,310);
        anchor6.setLocation(596,385);
        anchor7.setLocation(739,323);
        anchor16.setLocation(597,147);
        butoi10.setLocation(340,148);
        butoi4.setLocation(195,470);
        anchor3.setLocation(341,463);
        anchor2.setLocation(358,535);
        PersonStern personstern = new PersonStern(35, 35);
        addObject(personstern,677,349);
        personstern.setLocation(36,535);
        Stein stein = new Stein(35, 35);
        addObject(stein,359,491);
        stein.setLocation(87,538);
        liftclosed.setLocation(432,299);
        liftopen.setLocation(432,299);
        liftclosed.setLocation(432,303);
        liftopen.setLocation(432,300);
        liftclosed.setLocation(432,302);
        stein.setLocation(39,72);
        basis3.setLocation(750,156);
        removeObject(basis3);
        Placa placa9 = new Placa(70, 16);
        addObject(placa9,662,231);
        placa9.setLocation(771,152);
        placa9.setLocation(782,153);
        placa9.setLocation(783,152);
        placa9.setLocation(779,216);
        Placa placa10 = new Placa(70, 16);
        addObject(placa10,629,155);
        placa10.setLocation(784,148);
        placa7.setLocation(321,114);
        placa10.setLocation(784,145);
        butoi17.setLocation(781,121);
        butoi16.setLocation(613,229);
    }

    public void act()
    {
        if (getObjects(Stein.class).isEmpty()) 
            {
                Greenfoot.setWorld(new TheEnd());
                music.stop();
                Greenfoot.playSound("fanfare.wav");
                music.stop();
                Greenfoot.playSound("fluier.wav");
            }
    }

}
    /**
     * Prepare the world for the start of the program.
     * That is: create the initial objects and add them to the world.
     */

import greenfoot.*;  // (World, Actor, GreenfootImage, Greenfoot and MouseInfo)

/**
 * Write a description of class MyWorld1 here.
 * 
 * @author (your name) 
 * @version (a version number or a date)
 */

public class Level_1 extends World
{
    GreenfootSound music = new GreenfootSound("Rowing.wav");
    public Level_1()
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
        Placa placa2 = new Placa(400, 16);
        addObject(placa2,653,494);
        placa2.setLocation(644,500);
        placa2.setLocation(644,499);
        placa2.setLocation(644,498);
        placa.setLocation(200,497);
        placa.setLocation(200,499);
        placa.setLocation(200,498);
        Placa placa3 = new Placa(200, 16);
        addObject(placa3,40,307);
        placa3.setLocation(98,323);
        Placa placa4 = new Placa(100, 16);
        addObject(placa4,490,409);
        placa4.setLocation(50,416);
        Placa placa5 = new Placa(200, 16);
        addObject(placa5,657,412);
        placa5.setLocation(699,389);
        Placa placa6 = new Placa(16, 50);
        addObject(placa6,417,270);
        placa6.setLocation(206,306);
        placa5.setLocation(700,331);
        Placa placa7 = new Placa(16, 70);
        addObject(placa7,563,380);
        placa7.setLocation(592,358);
        Placa placa8 = new Placa(50, 16);
        addObject(placa8,369,222);
        placa8.setLocation(223,273);
        Placa placa9 = new Placa(80, 16);
        addObject(placa9,418,406);
        placa9.setLocation(560,400);
        Placa placa10 = new Placa(800, 23);
        addObject(placa10,530,291);
        placa10.setLocation(399,11);
        placa10.setLocation(400,10);
        placa10.setLocation(400,11);
        Placa placa11 = new Placa(23, 600);
        addObject(placa11,411,211);
        placa11.setLocation(9,300);
        Placa placa12 = new Placa(23, 600);
        addObject(placa12,461,267);
        placa12.setLocation(788,302);
        Placa placa13 = new Placa(300, 20);
        addObject(placa13,589,138);
        placa13.setLocation(628,129);
        Placa placa14 = new Placa(50, 16);
        addObject(placa14,452,298);
        placa14.setLocation(238,273);
        Placa placa15 = new Placa(50, 16);
        addObject(placa15,448,309);
        placa15.setLocation(221,273);
        placa15.setLocation(223,273);
        Placa placa16 = new Placa(50, 16);
        addObject(placa16,424,365);
        placa16.setLocation(302,330);
        placa15.setLocation(254,298);
        placa15.setLocation(244,273);
        placa16.setLocation(497,401);
        placa16.setLocation(501,401);
        liftopen liftopen = new liftopen();
        addObject(liftopen,667,92);
        liftopen.setLocation(661,86);
        liftclosed liftclosed = new liftclosed();
        addObject(liftclosed,661,86);
        liftclosed.setLocation(661,85);
        Stein stein = new Stein(40, 40);
        addObject(stein,569,252);
        stein.setLocation(530,70);
        PersonStern personstern = new PersonStern(40, 40);
        addObject(personstern,586,78);
        personstern.setLocation(586,84);
        Basis basis2 = new Basis(70, 50);
        addObject(basis2,457,316);
        basis2.setLocation(57,290);
        Placa placa17 = new Placa(400, 16);
        addObject(placa17,447,227);
        placa17.setLocation(470,206);
        Placa placa18 = new Placa(70, 16);
        addObject(placa18,607,261);
        placa18.setLocation(742,269);
        placa18.setLocation(742,264);
        Basis basis3 = new Basis(100, 50);
        addObject(basis3,582,462);
        basis3.setLocation(727,465);
        placa.setLocation(185,499);
        placa2.setLocation(648,497);
        placa2.setLocation(647,498);
        placa.setLocation(167,498);
        removeObject(basis3);
        Basis basis4 = new Basis(100, 30);
        addObject(basis4,514,432);
        basis4.setLocation(727,475);
        anchor anchor = new anchor();
        addObject(anchor,558,449);
        anchor.setLocation(493,452);
        anchor.setLocation(42,460);
        anchor anchor2 = new anchor();
        addObject(anchor2,751,369);
        anchor anchor3 = new anchor();
        addObject(anchor3,53,174);
        anchor anchor4 = new anchor();
        addObject(anchor4,184,531);
        anchor anchor5 = new anchor();
        addObject(anchor5,743,541);
        anchor anchor6 = new anchor();
        addObject(anchor6,575,375);
        anchor anchor7 = new anchor();
        addObject(anchor7,747,300);
        anchor anchor8 = new anchor();
        addObject(anchor8,757,169);
        anchor anchor9 = new anchor();
        addObject(anchor9,309,320);
        anchor6.setLocation(563,370);
        anchor6.setLocation(562,368);
        butoi butoi = new butoi();
        addObject(butoi,723,379);
        butoi butoi2 = new butoi();
        addObject(butoi2,763,237);
        butoi butoi3 = new butoi();
        addObject(butoi3,500,101);
        butoi butoi4 = new butoi();
        addObject(butoi4,118,297);
        butoi butoi5 = new butoi();
        addObject(butoi5,286,325);
        butoi butoi6 = new butoi();
        addObject(butoi6,43,372);
        butoi butoi7 = new butoi();
        addObject(butoi7,48,540);
        butoi butoi8 = new butoi();
        addObject(butoi8,602,545);
        butoi butoi9 = new butoi();
        addObject(butoi9,227,443);
        anchor9.setLocation(318,319);
        butoi8.setLocation(604,542);
        butoi.setLocation(692,382);
        butoi.setLocation(362,404);
        butoi.setLocation(653,394);
        butoi.setLocation(654,377);
        butoi.setLocation(670,384);
        stein.setLocation(405,175);
        personstern.setLocation(458,177);
        stein.setLocation(333,471);
        personstern.setLocation(479,464);
        personstern.setLocation(652,469);
        stein.setLocation(140,472);
        butoi9.setLocation(350,464);
        personstern.setLocation(228,465);
        stein.setLocation(640,470);
        personstern.setLocation(137,470);
        personstern.setLocation(137,469);
        butoi9.setLocation(284,177);
        butoi3.setLocation(753,96);
        anchor anchor10 = new anchor();
        addObject(anchor10,766,62);
        anchor10.setLocation(751,50);
        anchor10.setLocation(716,97);
        anchor10.setLocation(713,95);
        butoi5.setLocation(282,325);
        anchor9.setLocation(322,319);
        placa9.setLocation(560,401);
        butoi.setLocation(632,371);
        placa9.setLocation(560,407);
        placa16.setLocation(511,407);
        placa7.setLocation(592,364);
        placa5.setLocation(700,337);
        placa16.setLocation(511,410);
        placa9.setLocation(560,410);
        placa7.setLocation(593,368);
        placa5.setLocation(700,341);
        Basis basis5 = new Basis(80, 20);
        addObject(basis5,388,478);
        basis5.setLocation(285,480);
        basis5.setLocation(305,480);
        basis5.setLocation(301,480);
        basis5.setLocation(301,480);
        butoi butoi10 = new butoi();
        addObject(butoi10,362,473);
        butoi10.setLocation(357,473);
        butoi10.setLocation(354,471);
        Arici arici = new Arici(40, 30);
        addObject(arici,377,161);
        arici.setLocation(392,178);
        Placa placa19 = new Placa(150, 16);
        addObject(placa19,578,321);
        placa19.setLocation(660,341);
        placa19.setLocation(738,341);
        placa18.setLocation(720,271);
    }
    public void act()
    {
       
    if (getObjects(Stein.class).isEmpty()) 
        {
            Greenfoot.setWorld(new Level_2());
            music.stop();
        }
    }
}
    /**
     * Prepare the world for the start of the program.
     * That is: create the initial objects and add them to the world.
     */

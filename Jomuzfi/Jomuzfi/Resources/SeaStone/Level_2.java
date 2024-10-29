import greenfoot.*;  // (World, Actor, GreenfootImage, Greenfoot and MouseInfo)

/**
 * Write a description of class MyWorld1 here.
 * 
 * @author (your name) 
 * @version (a version number or a date)
 */

public class Level_2 extends World
{
    GreenfootSound music = new GreenfootSound("Rowing.wav");
    public Level_2()
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
        Placa placa10 = new Placa(800, 30);
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
        placa.setLocation(185,499);
        placa2.setLocation(648,497);
        placa2.setLocation(647,498);
        placa.setLocation(167,498);
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
        anchor3.setLocation(409,296);
        basis4.setLocation(295,399);
        placa.setLocation(212,500);
        basis4.setLocation(295,408);
        butoi10.setLocation(354,468);
        placa.setLocation(212,498);
        liftclosed.setLocation(396,75);
        liftopen.setLocation(63,148);
        liftclosed.setLocation(64,149);
        basis2.setLocation(66,290);
        liftclosed.setLocation(148,142);
        liftopen.setLocation(63,129);
        liftclosed.setLocation(64,129);
        liftclosed.setLocation(63,129);
        butoi4.setLocation(227,243);
        anchor10.setLocation(693,65);
        placa13.setLocation(628,84);
        butoi3.setLocation(749,58);
        anchor10.setLocation(710,52);
        butoi7.setLocation(86,454);
        anchor4.setLocation(184,468);
        placa.setLocation(212,525);
        butoi8.setLocation(568,451);
        anchor5.setLocation(710,444);
        placa2.setLocation(638,524);
        placa.setLocation(208,525);
        greenf greenf = new greenf(25, 25);
        addObject(greenf,504,479);
        greenf.setLocation(517,491);
        greenf greenf2 = new greenf(25, 25);
        addObject(greenf2,388,494);
        greenf2.setLocation(383,495);
        liftclosed.setLocation(134,139);
        liftopen.setLocation(72,159);
        liftopen.setLocation(74,161);
        liftclosed.setLocation(74,160);
        arici.setLocation(415,182);
        anchor8.setLocation(490,176);
        butoi9.setLocation(332,181);
        butoi2.setLocation(605,313);
        anchor7.setLocation(719,239);
        placa19.setLocation(728,307);
        placa19.setLocation(703,305);
        placa19.setLocation(725,301);
        placa19.setLocation(723,300);
        placa5.setLocation(699,399);
        placa7.setLocation(593,426);
        placa9.setLocation(626,469);
        stein.setLocation(563,495);
        butoi8.setLocation(615,442);
        anchor5.setLocation(648,437);
        placa16.setLocation(691,469);
        basis2.setLocation(74,290);
        butoi4.setLocation(144,298);
        anchor3.setLocation(67,231);
        anchor.setLocation(48,551);
        greenf2.setLocation(289,446);
        basis4.setLocation(256,461);
        greenf2.setLocation(247,429);
        butoi10.setLocation(362,469);
        Arici arici2 = new Arici(40, 30);
        addObject(arici2,322,501);
        arici2.setLocation(316,500);
        greenf.setLocation(466,496);
        butoi2.setLocation(721,552);
        anchor.setLocation(57,548);
        anchor.setLocation(57,549);
        butoi2.setLocation(721,551);
        placa17.setLocation(396,229);
        placa6.setLocation(203,326);
        placa17.setLocation(725,341);
        placa19.setLocation(461,442);
        placa17.setLocation(723,338);
        placa17.setLocation(723,340);
        placa18.setLocation(548,407);
        placa19.setLocation(464,459);
        placa18.setLocation(551,414);
        placa17.setLocation(756,343);
        placa18.setLocation(488,401);
        placa19.setLocation(474,459);
        anchor6.setLocation(412,429);
        placa6.setLocation(200,322);
        placa13.setLocation(631,184);
        anchor10.setLocation(702,144);
        butoi3.setLocation(760,151);
        anchor10.setLocation(717,149);
        anchor10.setLocation(601,132);
        butoi3.setLocation(666,137);
        Basis basis6 = new Basis(40, 50);
        addObject(basis5,607,178);
        basis5.setLocation(757,150);
        butoi3.setLocation(763,60);
        anchor10.setLocation(729,74);
        anchor8.setLocation(558,134);
        placa15.setLocation(239,292);
        placa14.setLocation(293,275);
        placa8.setLocation(217,291);
        placa15.setLocation(239,291);
        placa14.setLocation(249,291);
        butoi9.setLocation(752,280);
        basis4.setLocation(392,246);
        basis4.setLocation(397,389);
        arici.setLocation(209,270);
        arici2.setLocation(46,501);
        butoi7.setLocation(205,389);
        anchor4.setLocation(89,454);
        personstern.setLocation(144,492);
        greenf2.setLocation(325,498);
        anchor6.setLocation(480,370);
        basis4.setLocation(476,296);
        butoi10.setLocation(414,433);
        anchor6.setLocation(515,373);
        Arici arici3 = new Arici(40, 30);
        addObject(arici3,454,351);
        arici3.setLocation(466,377);
        Arici arici4 = new Arici(40, 30);
        addObject(arici4,524,147);
        arici4.setLocation(631,159);
        Placa placa20 = new Placa(70, 16);
        addObject(placa20,455,390);
        placa20.setLocation(326,382);
        placa20.setLocation(290,383);
        placa20.setLocation(279,383);
        Placa placa21 = new Placa(70, 16);
        addObject(placa21,463,407);
        placa21.setLocation(332,383);
        basis4.setLocation(171,457);
        Basis basis3 = new Basis(70,16);
        addObject(basis3,467,293);
        basis3.setLocation(467,293);
        Basis basis7 = new Basis(80, 16);
        addObject(basis7,501,241);
        basis7.setLocation(381,222);
        removeObject(basis5);
        Basis basis8 = new Basis(100, 25);
        addObject(basis8,467,258);
        basis8.setLocation(372,226);
    }
        public void act()
    {
       
    if (getObjects(Stein.class).isEmpty()) 
        {
            Greenfoot.setWorld(new Bonus_Level());
            music.stop();
        }
    }
}
    /**
     * Prepare the world for the start of the program.
     * That is: create the initial objects and add them to the world.
     */

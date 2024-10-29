using Jomuzfi;
using System;
using System.Windows.Forms;

public class Repo
{

	public Repo()
	{

	}

	public Movie[] create_list()
	{
		// die Datenbank erstellen
		string[] titles = {"Suicide Squad", "Titanic", "Pirates of the Caribbean", "Murder on the orient express", "Avatar", "The professor", "Dead Poets Society", "Frozen", "Joker", "The Giver"};
		string[] genres = {"action", "drama", "action", "mystery", "SF", "comedy", "drama", "animation", "thriller", "SF"};
		int[] years = {2016, 1997, 2017, 2017, 2009, 2018, 1989, 2013, 2019, 2014};
		int[] likes = {10, 11, 9, 8, 7, 7, 10, 8, 9, 11};
		String[] trailers = {"https://www.youtube.com/watch?v=CmRih_VtVAs", "https://www.youtube.com/watch?v=2e-eXJ6HgkQ", "https://www.youtube.com/watch?v=naQr0uTrH_s", "https://www.youtube.com/watch?v=Mq4m3yAoW8E", "https://www.youtube.com/watch?v=5PSNL1qE6VY", "https://www.youtube.com/watch?v=IThXCpk3Oc4", "https://www.youtube.com/watch?v=4lj185DaZ_o", "https://www.youtube.com/watch?v=R-cdIvgBCWY", "https://www.youtube.com/watch?v=zAGVQLHvwOY", "https://www.youtube.com/watch?v=uxFJvlWqphM"};

		for (int i = 0; i < 10; i++)
		{
			Movie m = new Movie(titles[i], genres[i], years[i], likes[i], trailers[i]);
			Jomuzfi.Listclass.movies[i]=m;
		}

		return Jomuzfi.Listclass.movies;
	}

	// eine Funktion um die Filme auch als Benutzer und als Admin hinzufugen
	// option2 = user/admin
    public Movie[] add_movie2(Movie m, string option2)
    {
        bool found = false;
        for (int i = 0; i < Jomuzfi.Listclass.length; i++)
        {
            // uberprufen ob der Film in der Datenbank existiert (wir uberprufen auch das Jahr, weil einen Film in verschiedenen Jahren veroffentlich werden kann)
            if (Jomuzfi.Listclass.movies[i].getTitle() == m.getTitle() && Jomuzfi.Listclass.movies[i].getYear() == m.getYear())
            {
                found = true;
            } 
        }

        // wenn der Film nicht existiert und wir als Admin arbeiten => den Film in der Datenbank hinzufugen
        if (!found && option2 == "admin")
        {
            Jomuzfi.Listclass.movies[Jomuzfi.Listclass.length] = m;
            Jomuzfi.Listclass.length++;
            MessageBox.Show(m.getTitle()+" added successfully!");
            return Jomuzfi.Listclass.movies;
        }
        // wenn der Film nicht existiert und wir als Benutzer arbeiten => kann der Film nicht in der Watchliste hinzugefugt werden 
        else if (!found && option2 == "user")
        {
            MessageBox.Show("Sorry, the movie doesn't exist :(");
            return Jomuzfi.Listclass.watchlist;
        }
        // wenn der Film existiert und wir als Admin arbeiten => kann der Film nicht in der Datenbank noch einmal hinzugefugt werden 
        else if (found && option2 == "admin")
        {
            MessageBox.Show("Sorry, the movie already exists...");
            return Jomuzfi.Listclass.movies;
        }
        // wenn der Film existiert und wir als Benutzer arbeiten => suchen wir den Film in der Watchliste 
        else if (found && option2 == "user")
        {
            bool wfound = false;
            for (int j = 0; j < Jomuzfi.Listclass.wlen; j++)
            {
                if (Jomuzfi.Listclass.watchlist[j].getTitle() == m.getTitle() && Jomuzfi.Listclass.watchlist[j].getYear() == m.getYear())
                {
                    wfound = true;
                }
            }
            // wenn wir den Film nicht gefunden haben => wird es hinzugefugt
            if (!wfound)
            {
                Jomuzfi.Listclass.watchlist[Jomuzfi.Listclass.wlen] = m;
                Jomuzfi.Listclass.wlen++;
                MessageBox.Show("YAY! You just added " + m.getTitle() + " in your watchlist!");
            }
            // wenn wird den Film gefunden haben => Nachricht
            else
            {
                MessageBox.Show("Aww... it seems like you really like this movie, because you wanted to add it again in your watchlist!");
            }
            return Jomuzfi.Listclass.watchlist;
        }
        return Jomuzfi.Listclass.watchlist;
    }
    // option2 = title/genre/year/likes/trailer
    public void edit_movie(string title, int year, string option2)
    {
        bool found = false;
        if (option2 == "title")
        {
            // der Film in der Datenbank suchen; wenn wir es gefunden haben => andern wir den Titel mit new_title
            for (int i = 0; i < Jomuzfi.Listclass.length; i++)
            {
                if (Jomuzfi.Listclass.movies[i].getTitle() == title && Jomuzfi.Listclass.movies[i].getYear() == year)
                {
                    Console.Write("New title: ");
                    string new_title;
                    new_title = Console.ReadLine();
                    Jomuzfi.Listclass.movies[i].setTitle(new_title);
                    Console.Write("Great! You just updated the title!");
                    Console.Write("\n");
                    found = true;
                }
            }
        }

        else if (option2 == "genre")
        {
            // der Film in der Datenbank suchen; wenn wir es gefunden haben => andern wir das Genre mit new_genre
            for (int i = 0; i < Jomuzfi.Listclass.length; i++)
            {
                if (Jomuzfi.Listclass.movies[i].getTitle() == title && Jomuzfi.Listclass.movies[i].getYear() == year)
                {
                    Console.Write("New genre: ");
                    string new_genre;
                    new_genre = Console.ReadLine();
                    Jomuzfi.Listclass.movies[i].setGenre(new_genre);
                    Console.Write("Great! You just updated the genre!");
                    Console.Write("\n");
                    found = true;
                }
            }
        }

        else if (option2 == "year")
        {
            // der Film in der Datenbank suchen; wenn wir es gefunden haben => andern wir das Jahr mit new_year
            for (int i = 0; i < Jomuzfi.Listclass.length; i++)
            {
                if (Jomuzfi.Listclass.movies[i].getTitle() == title && Jomuzfi.Listclass.movies[i].getYear() == year)
                {
                    Console.Write("New year: ");
                    int new_year;
                    new_year = int.Parse(Console.ReadLine());
                    Jomuzfi.Listclass.movies[i].setYear(new_year);
                    Console.Write("Great! You just updated the year!");
                    Console.Write("\n");
                    found = true;
                }
            }
        }

        else if (option2 == "likes")
        {
            // der Film in der Datenbank suchen; wenn wir es gefunden haben => andern wir die Anzahl von Likes mit new_likes
            for (int i = 0; i < Jomuzfi.Listclass.length; i++)
            {
                if (Jomuzfi.Listclass.movies[i].getTitle() == title && Jomuzfi.Listclass.movies[i].getYear() == year)
                {
                    Console.Write("New number of likes: ");
                    string new_likestring = Console.ReadLine();
                    int new_like = Convert.ToInt32(new_likestring);
                    Jomuzfi.Listclass.movies[i].setLikes(new_like);
                    Console.Write("Great! You just updated the likes!");
                    Console.Write("\n");
                    found = true;
                }
            }
        }

        else if (option2 == "trailer")
        {
            // der Film in der Datenbank suchen; wenn wir es gefunden haben => andern wir den Trailer mit new_trailer
            for (int i = 0; i < Jomuzfi.Listclass.length; i++)
            {
                if (Jomuzfi.Listclass.movies[i].getTitle() == title && Jomuzfi.Listclass.movies[i].getYear() == year)
                {
                    Console.Write("New url for trailer: ");
                    String new_trailer;

                    // wir lesen den URL als Char
                    string myString = new string(new char[256]);
                    myString = Console.ReadLine();
                    // wir verwandeln dem Char in CString
                    new_trailer = myString.ToString();
                    Jomuzfi.Listclass.movies[i].setTrailer(new_trailer);
                    Console.Write("Great! You just updated the url!");
                    Console.Write("\n");
                    found = true;
                }
            }
        }

        // wenn die Option nicht gultig ist => Nachricht
        else
        {
            Console.Write("Sorry, the option2 is not valid...");
            Console.Write("\n");
        }

        if (!found)
        {
            Console.Write("The movie is not in the list. Try to edit another movie.");
        }
    }

    public Movie[] delete_movie_list(string title, int year)
    {
        //Loscht durch den Administratormode ein Film aus der Liste
        int found = -1;
        //Sucht den Film und speichert die Position
        for (int i = 0; i < Jomuzfi.Listclass.length; i++)
        {
            if (Jomuzfi.Listclass.movies[i].getTitle() == title && Jomuzfi.Listclass.movies[i].getYear() == year)
            {
                found = i;
                break;
            }
        }
        //Verschiebt im Vektor und so wird der Film mit dem gegebenen Titel und Jahr geloscht
        if (found != -1)
        {
            for (int j = found + 1; j < Jomuzfi.Listclass.length; j++)
            {
                Jomuzfi.Listclass.movies[j - 1] = Jomuzfi.Listclass.movies[j];
            }
            Jomuzfi.Listclass.length--;
            string text = "You just deleted the movie: " + title + " from the list! Hope you are happy...";
            MessageBox.Show(text);
        }
        else
        {
            MessageBox.Show("The movie you wanted to delete was not in the list...Try to delete another movie, if you want to.");
        }
        return Jomuzfi.Listclass.movies;
    }

    public Movie[] delete_movie_watchlist(string title, int year)
    {
        //Loscht ein Film aus der Watchiste des Users
        int found = -1;
        if (Listclass.wlen == 0)
        {
            MessageBox.Show("Your watchlist is empty. Try adding a movie first.");
        }
        else
        {
            for (int i = 0; i < Listclass.wlen; i++)
            {
                if (Jomuzfi.Listclass.watchlist[i].getTitle() == title && Jomuzfi.Listclass.watchlist[i].getYear() == year)
                {
                    found = i;
                    break;
                }
            }
            //Verschiebt im Vektor und so wird der Film mit dem gegebenen Titel und Jahr geloscht
            if (found == -1)
            {
                MessageBox.Show("The movie you wanted to delete was not in the list...Try to delete another movie, if you want to.");
            }
            else
            {
                for (int j = found + 1; j < Listclass.wlen; j++)
                {
                    Jomuzfi.Listclass.watchlist[j - 1] = Jomuzfi.Listclass.watchlist[j];
                }
                Listclass.wlen--;
                found = 1;
                MessageBox.Show("You just deleted the movie: "+title+" from the list!");
            }
        }
        return Jomuzfi.Listclass.watchlist;
    }

}
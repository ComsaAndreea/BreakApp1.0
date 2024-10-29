using System;

public class Movie
{
	private string title;
	private string genre;
	private int year;
	private int likes;
	private String trailer;

	public Movie()
	{
		this.title = "";
		this.genre = "";
		this.year = 0;
		this.likes = 0;
		this.trailer = "";
	}

	public Movie(string title, string genre, int year, int likes, String trailer)
	{
		this.title = title;
		this.genre = genre;
		this.year = year;
		this.likes = likes;
		this.trailer=trailer;
	}

	//getters
	public string getTitle()
	{
		return title;
	}
	public string getGenre()
	{
		return genre;
	}
	public int getYear()
	{
		return year;
	}
	public int getLikes()
	{
		return likes;
	}
	public String getTrailer()
	{
        return trailer;
	}

	//setters
	public void setTitle(string newTitle)
	{
		title = newTitle;
	}
	public void setGenre(string newGenre)
	{
		genre = newGenre;
	}
	public void setYear(int newYear)
	{
		year = newYear;
	}
	public void setLikes(int newLikes)
	{
		likes = newLikes;
	}
	public void setTrailer(String newTrailer)
	{
		trailer=newTrailer;
	}

}

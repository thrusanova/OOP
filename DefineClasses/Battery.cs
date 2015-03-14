
using System;
using System.Collections.Generic;
using System.Text;


namespace DefineClasses
{
    //task 1
  public  class Battery

    {
     //fields
	private string model=null;
	private int hoursIdle;
	private int hoursTalk;
	private BatterryType type;
	//task 2 
//constructors
	public Battery()
        {

        }
    public Battery(string model, int hoursIdle, int hoursTalk, BatterryType type)
    {
        this.Model = model;
        this.HoursIdle = hoursIdle;
        this.HoursTalk = hoursTalk;
        this.Type = type;
    }
 //task 5
//property
	public string Model
	{	
		get
		{	
			return this.model;
		}
		private set
		{
			if (value.Length==0 || value.Length>8)
			{
                throw new ArgumentException("The model name must be longer than 0 or shorter than 20 letters");
			}
			else
			{	
				this.model=value;
			}
		}
	}
		public int HoursIdle
	{
		get
		{
			return this.hoursIdle;
		}
	private	set
		{
			if (value <0)
			{
                throw new ArgumentException("The idle hours must not be negative");
			}
			else
			{
				this.hoursIdle=value;
			}
		}
	}
	
	public int HoursTalk
	{	
		get
		{
			return this.hoursTalk;
		}
		private set
		{
			if (value<0)
			{
                throw new ArgumentException("The talk hours must not be negative");
			}
			else
			{	
				this.hoursTalk=value;
			}
		}
	}
	public BatterryType Type
	{
		get
		{
			return this.type;
		}
		private set
		{	
			this.type=value;
		}
	}
	
	public override string ToString ()
	{	
		return String.Format("Model {0}, Hours Idle {1} ,Hours Talk {2}, Battery type {3}",
		this.model,this.hoursIdle,this.hoursTalk,this.type);
	}
}
}

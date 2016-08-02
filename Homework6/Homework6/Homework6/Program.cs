using System;
//Modify the Television class to use properties instead of functions.The Main function has already been modified to use the new properties.



class Television
{
    private int channel = 0;
    private  int volume = 0;
    private bool isOn = false;
    private int Channel;

    public bool IsOn

    {
        get{return isOn;}
        set { isOn = true; }
    }

    public bool TurnOn

    {
        
        set { isOn = true; }
       
        // do the code to turn the tv on
    }

    public bool TurnOff
    {
        set { isOn = false; }
        
        // do the code to turn the tv off
    }

    public int CurrentVolume
        
    {
        get { return volume; }
    }

    public int IncreaseVolume
    {
        get
        {
            if (volume < 100)
            {
                volume = volume + 1;
                // do the code to increase the volume
            }
            return volume;
        }
    }
    public int DecreaseVolume
    {
        get
        {
            if (volume > 0)
            {
                volume = volume - 1;
                // do the code to decrease the volume
            }
            return volume;

        }
    }

    public int CurrentChannel
    {
       get { return channel; }
    }


    public int ChangeChannel
    {
       get
        {
            if (Channel > 0 && Channel < 50)
            {
                channel = Channel;
                // do the code to change the
                // channel on the tv
            }
            return channel;
        }
  
    }
}

class TestTV
{
    static void Main()
    {
        Television tv = new Television();

        if (!tv.IsOn)
        {
            tv.IsOn = true;
        }

        tv.Channel = 3;

        tv.volume++;
        tv.volume++;
        tv.volume++;
        tv.volume++;

        tv.IsOn = false;
    }
}
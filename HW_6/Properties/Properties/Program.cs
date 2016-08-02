using System;
//Modify the Television class to use properties instead of functions.The Main function has already been modified to use the new properties.



class Television
{
    int channel = 0;
    public int volume = 0;
    private bool isOn = false;
    public int Channel;

    public bool IsOn

    {
        get { return isOn; }
        set { isOn = true; }
    }

    public bool TurnOn

    {
        get { return isOn; }
        set { isOn = true; }

        // do the code to turn the tv on
    }

    public bool TurnOff
    {

        get { return isOn; }
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
            return volume;
        }

        set
        {
            if (volume < 100)
            {
                volume = volume + 1;
                // do the code to increase the volume
            }
          }

     
    }
    public int DecreaseVolume
    {
        get
        {
            return volume;
        }
        set
        {
            if (volume > 0)
            {
                volume = volume - 1;
                // do the code to decrease the volume
            }

        }
      
    }

    public int CurrentChannel
    {
        get { return channel; }
    }


    public int  ChangeChannel
    {

        get
        {
            return channel;
        }
        set
        {
            

            if (Channel > 0 && Channel < 50)
            {
                channel = Channel;
                // do the code to change the
                // channel on the tv
            }
           
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

namespace Bottles;

public class Bottle
{
    private readonly int _capacity;
    public int _content { get; private set; }

    public Bottle(int capacity)
    {
        _capacity = capacity;
        _content = 0;
    }

    public void FillFromTap()
    {
        _content = _capacity;
    }

    public void EmptyInto(Bottle bottle)
    {
        var availableVolume = bottle._capacity - bottle._content;
        if (availableVolume < _content)
        {
            bottle._content = bottle._capacity;
            _content -= availableVolume;
        }
        else
        {
            bottle._content += _content;
            _content = 0;
        }
    }

    public void FillWith(Bottle bottle)
    {
        var availableVolume = _capacity - _content;
        if (availableVolume < bottle._content)
        {
            _content = _capacity;
            bottle._content -= availableVolume;
        }
        else
        {
            _content += bottle._content;
            bottle._content = 0;
        }
    }

    public void Empty()
    {
        _content = 0;
    }
}
using System;
using System.Collections.Generic;

public class CircularBuffer<T>
{
    private int _capacity;
    private List<int> _buffer;
    private int _writtenAmount = 0;

    public CircularBuffer(int capacity)
    {
        this._capacity = capacity;
        this._buffer = new List<int>();
    }

    public int Read()
    {
        if(this._buffer.Count == 0) {
            throw new InvalidOperationException();
        } else {
            var returnValue = this._buffer[0];
            this._buffer.RemoveAt(0);
            this._writtenAmount -= 1;
            return returnValue;
        }
    }

    public void Write(T value)
    {
        this._writtenAmount += 1;
        if(this._writtenAmount > this._capacity)
        {
            throw new InvalidOperationException();
        } else {
            this._buffer.Add(Convert.ToInt32(value));
        }
    }

    public void Overwrite(T value)
    {
        this._writtenAmount += 1;
        if(this._writtenAmount > this._capacity)
        {
            this._buffer.RemoveAt(0);
            // overwrite oldest item on full buffer
            // System.Console.WriteLine("==================");
            // for(var i = 0; i < this._buffer.Count ; i++ )
            // {
            //     System.Console.WriteLine(_buffer[i]);
            // }

            this._buffer.Add(Convert.ToInt32(value));
        } else {
            this._buffer.Add(Convert.ToInt32(value));
        }
    }

    public void Clear()
    {
        this._buffer = new List<int>();
        this._writtenAmount = 0;
    }
}
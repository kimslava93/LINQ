﻿namespace LINQ_test.Driver
{
    class Endpoint
    {
        bool state;
        Device parent;
        byte inter_id;
        public Endpoint(Device prnt, byte id)
        {
            parent = prnt;
            state = false;
            inter_id = id;

        }

        public bool ON()
        {
            byte[] msg = new byte[2];
            msg[0] = inter_id; //Number
            msg[1] = 1;  //OFF
            if(parent.send_packet(msg))
            {
                state = true;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool OFF()
        {
            byte[] msg = new byte[2];
            msg[0] = inter_id; //Number
            msg[1] = 0;  //OFF
            if(parent.send_packet(msg))
            {
                state = false;
                return true;
            }
            else
            {
                return false;
            }
        }
        

        public bool State
        {
            get { return state; }
        }

        public override string ToString()
        {
            return parent.ToString() + "-" + inter_id.ToString();
        }

    }
}

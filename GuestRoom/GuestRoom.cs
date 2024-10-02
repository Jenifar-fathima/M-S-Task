﻿namespace GuestRoom
{
    public class GuestRoom
    {
        public static string RoomSeperation(int nAdult, int nChildren)
        {
            int nTotalPeople = nAdult + nChildren;
            int nRoomCount = 0;
            string strResultString = "";
            while (nRoomCount < 4 && nTotalPeople <= 16 && nAdult != 0)
            {
                nRoomCount += 1;
                int adultCount = 0;
                int childrenCount = 0;
                int nTotalPersonInRoom = 0;

                if (nAdult > 0)
                {
                    adultCount = 1;
                    nAdult -= adultCount;
                    nTotalPersonInRoom += adultCount;
                }

                while (nTotalPersonInRoom < 4 && nTotalPersonInRoom < nTotalPeople)
                {
                    if (nChildren > 0 && nTotalPersonInRoom < 4)
                    {
                        childrenCount += 1;
                        nChildren -= 1;
                    }
                    else if (nAdult > 0 && nTotalPersonInRoom < 4)
                    {
                        adultCount += 1;
                        nAdult -= 1;
                    }
                    nTotalPersonInRoom = adultCount + childrenCount;
                }
                nTotalPeople = nAdult + nChildren;
                strResultString += $"room {nRoomCount}:Adult {adultCount} - Children {childrenCount}\n";
            }
            return strResultString;
        }
    }
}
using System;
using System.Collections.Generic;

namespace Organizer1
{
    public class Organizer
    {
        public List<Data> list = new List<Data>();
        public Organizer(Data data)
        {
            list.Add(data);
        }

        public void add(Data data)
        {
            this.list.Add(data);
        }

        public Organizer()
        {

        }

        public void remove(int index)
        {
            if (index < list.Count)
            {
                list.RemoveAt(index);
            }
        }

        public List<Data> findByText(string text)
        {
            List<Data> tmpList = new List<Data>();
            list.ForEach(item =>
            {
                if (item.Event.IndexOf(text) >= 0)
                {
                    tmpList.Add(item);
                } 
            });
            return tmpList;
        }

        public List<Data> findByCategory(EventType type)
        {
            List<Data> tmpList = new List<Data>();
            list.ForEach(item =>
            {
                if (item.eventType == type)
                {
                    tmpList.Add(item);
                }
            });
            return tmpList;
        }

        public void sortByTime(int direction = 0)
        {
            list.Sort((x, y) => 
            {
                int timeX = x.Time.Hours * 3600 + x.Time.Minutes;
                int timeY = y.Time.Hours * 3600 + y.Time.Minutes;

                if (direction == 0)
                {
                    if (timeX > timeY)
                        return 1;
                    if (timeX < timeY)
                        return -1;
                    if (timeX == timeY)
                        return 0;
                }
                return 0;
            });
        }
    }
}

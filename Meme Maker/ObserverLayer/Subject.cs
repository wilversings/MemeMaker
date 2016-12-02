﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace MemeMaker.ObserverLayer {
    public class Subject<T> {

        private List<IObserver> observers;
        public List<string> PathList { get; set; }

        public Subject () {
            this.observers = new List<IObserver> ();
            this.PathList = new List<string> ();
        }

        public void AddObserver(IObserver obs) {
            observers.Add (obs);
        }
        public void RemoveObserver(IObserver obs) {
            observers.Remove (obs);
        }

        public void NotifyAll () {
            observers.ForEach (o => o.Notify ());
        }
        public void NotifyBy (Func<IObserver, bool> byFn) {
            observers.ForEach (o => {
                if (byFn (o)) {
                    o.Notify ();
                }
            });
        }

    }
}

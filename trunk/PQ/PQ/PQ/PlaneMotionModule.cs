﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace PQ
{
    public class PlaneMotionModule
    {
        protected float _vx;
        public float Vx
        {
            get { return _vx; }
            set { _vx = value; }
        }

        protected float _vy;
        public float Vy
        {
            get { return _vy; }
            set { _vy = value; }
        }

        //double _lastTime = 0;

        public virtual void OnMotion(GameObject gameObj, GameTime gameTime)
        {
            
        }
    }
}
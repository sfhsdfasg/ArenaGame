﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class Camera
    {
        private Matrix transform;
        public Matrix Transform{get { return transform;  }}
        private Vector2 center;

        public void Update(float x, float y, int xOffset, int yOffset)
        {
            center = new Vector2(x + 64 / 2 - xOffset / 2, y + 64 / 2 - yOffset / 2);

            transform = Matrix.CreateTranslation(new Vector3(-center.X, -center.Y, 0)) *
                                                 Matrix.CreateScale(new Vector3(1, 1, 0));
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace PQ
{
    enum CharacterName
    {
        MaleHeroKnight1,
        MaleHeroKnight2
    }

    public class CharacterManager : AbstractManager
    {
        public override void LoadPrototypes(ContentManager content)
        {
            //_prototypes = new List<object>();
            _prototypes = new Dictionary<int, object>();

            SplittingDetails details = new SplittingDetails(4, 8, 0, 0, 49, 49, 0, 0, 0, 0);

            //details.RowCount = 4;
            //details.ColumnCount = 8;
            //details.FrameWidth = details.FrameHeight = 49;

            GameEntity character = new Character();
            Texture2D tmpTexture = content.Load<Texture2D>(@"Images\MaleHeroKnight1_49x49");
            character.Sprites.Add(new Sprite2D(tmpTexture, 0, 0, details, 8));
            character.UpdateChild();
            _prototypes.Add((int)CharacterName.MaleHeroKnight1, character);

            tmpTexture = content.Load<Texture2D>(@"Images\MaleHeroKnight2_49x49");
            character = new Character();
            character.Sprites.Add(new Sprite2D(tmpTexture, 0, 0, details, 8));
            character.UpdateChild();
            _prototypes.Add((int)CharacterName.MaleHeroKnight2, character);
        }

        public override object CreateObject(int idx)
        {
            return (_prototypes[idx] as Character).Clone();
        }
    }
}
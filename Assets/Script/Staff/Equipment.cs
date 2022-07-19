using UnityEngine;

namespace Script.Staff
{
    public abstract class Equipment : Staff
    {
        public abstract void PutUp();
        public abstract void PutDown();

        public abstract bool BodyBlockIsEmpty();
    }
}
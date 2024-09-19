using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPool : MonoBehaviour
{
    public Bullet bulletPrefab;
    public List<PooledBullet> pooledBullets = new List<PooledBullet>();
    public Bullet GetPooledBullet()
    {
        if (pooledBullets.Count > 0)
        {
            PooledBullet pooledBullet = pooledBullets.Find(item => !item.isUsed);
            if(pooledBullet!=null)
            {
                return pooledBullet.bullet;
            }
        }
        return CreatePooledBullet();
    }
    Bullet CreatePooledBullet()
    {
        PooledBullet newBullet = new PooledBullet();
        //  newBullet = Instantiate<Bullet>(bulletPrefab)
        newBullet.bullet = Instantiate<Bullet>(bulletPrefab);
        newBullet.isUsed = true;
        pooledBullets.Add(newBullet);
        return newBullet.bullet;
    }

    public class PooledBullet
    {
        public Bullet bullet;
        public bool isUsed;
    }
}

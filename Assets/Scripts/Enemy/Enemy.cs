
public abstract class Enemy 
{
    protected int health;
    protected int strikeDamage;
    protected float moveSpeed;
    public abstract void Attack();
    public abstract void TakeDamage();
    public abstract void HandleEnemyMovement();
  
}

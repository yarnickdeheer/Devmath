using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DevMath
{
    public class Rigidbody
    {
        public Vector2 Velocity //assen x en y
        {
            get; private set;
        }

        public float Acceleration
        {
            get; private set;
        }

        public float mass = 1.0f;

        public float frictionCoefficient;
        public float normalForce;

        public void UpdateVelocityWithForce(Vector2 forceDirection, float forceNewton, float deltaTime)
        {
            //// verplaatsing = velocity * tijd = (vector)
            /// afstand = acceleration * tijd  = (scaler)
            /// welke direction
            /// 

            float force = forceNewton - (normalForce * frictionCoefficient);
            float acceleration = force * mass * deltaTime;
            Velocity = new Vector2(acceleration, acceleration);


 //           float friction = normalForce * frictionCoefficient;
 //           float mag = (float)Math.Sqrt((forceDirection.x*forceDirection.x)+(forceDirection.y*forceDirection.y));
 //        Acceleration = (float)(forceNewton - friction);


 //            Velocity = new Vector2((forceDirection.x* Acceleration / mag),(forceDirection.y* Acceleration / mag));


 //           forceDirection = new Vector2((forceDirection.x * Velocity.x * deltaTime) , (forceDirection.y * Velocity.y * deltaTime));
        }
       
        
        
        
        
        /// schiet object in directie * force en time
        /// velocityv equels force divided by mass multiplued by time
        /// 
        /// acceleratie = force / tijd
        /// 
        /// force = massa * acceleratie
        /// 
        /// veocity vector = speed/magnitude(forceDirection.x,forceDirection.y)
        /// Velocity = (force / mass) * deltaTime

    }
}
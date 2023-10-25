using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;

namespace Lab1
{
    internal class Semisphere {
        private int radius, angle;

        public Semisphere(int radius, int angle) {
            if (radius <= 0) {
                throw new ArgumentException("Радіус повинен бути додатнім числом.");
            }

            this.radius = radius;
            this.angle = angle;
        }

        public double CalculateArea() {
            return 0.5 * Math.PI * radius * radius;
        }

        public double CalculateArcLength() {
            if (angle < 0 || angle > 180) {
                throw new ArgumentException("Кут повинен бути між 0 і 180 градусів.");
            }

            double angleRad = angle * (Math.PI / 180);

            return radius * angleRad;
        }

        public string IsPointInside(int x, int y) {
            string answer;
            double distance = Math.Sqrt(x * x + y * y);

            if (distance <= radius) {
                answer = "так";
                return answer;
            }
            else {
                answer = "ні";
                return answer;
            }
        }
    }
}

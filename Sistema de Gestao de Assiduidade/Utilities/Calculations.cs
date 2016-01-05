using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Globalization;

namespace mz.betainteractive.sigeas.utilities {
    class Mathematics {

        public static DayOfWeek FirstDayOfWeek = DayOfWeek.Monday;

        /**
         * Retorna array de 32bits
         * Retorna uma array de 0 e 1s invertida
         * Onde a posição 0 da array representa o bit(31)
         */ 
        public static int[] GetBits(int num) {
            int[] bit = new int[32];

            for (int i = bit.Length - 1, x=0; i >= 0; i--, x++) {
          //the bit pos we want <-|    |-> just one bit
                bit[x] = ((num >> i) & 1);
            }

            return bit;
        }

        /**
         * Retorna array de 8bits
         * Retorna uma array de 0 e 1s invertida
         * Onde a posição 0 da array representa o bit(7)
         */
        public static int[] GetBits(byte num) {
            int[] bit = new int[8];
            
            for (int i = bit.Length - 1, x = 0; i >= 0; i--, x++) {
                //the bit pos we want <-|    |-> just one bit
                bit[x] = ((num >> i) & 1);
            }

            return bit;
        }

        public static byte GetByte(int[] bit) {
            byte num = 0;

            for (int i = 0, x = bit.Length - 1; i < bit.Length; i++, x--) {
                num = (byte) (num | (bit[i] << x));
            }

            return num;
        }

        public static int[] GetBits(int num, int number_of_bits) {
            
            if (number_of_bits > 32) {
                number_of_bits = 32;
            }

            int[] bit = new int[number_of_bits];

            for (int i = bit.Length - 1, x = 0; i >= 0; i--, x++) {
                //the bit pos we want <-|    |-> just one bit
                bit[x] = ((num >> i) & 1);
            }

            return bit;
        }

        /**
         * Recebe uma array de bits cuja a posição 0 da array
         * representa o ultimo bit
         */ 
        public static int GetNumber(int[] bit) {
            int num = 0;

            for (int i = 0, x = bit.Length-1; i < bit.Length; i++, x--) {
                num = num | (bit[i] << x);
            }

            return num;
        }
                
        public static int GetWeekDay(DayOfWeek day) {
            switch (day) {
                case DayOfWeek.Monday: return 1;
                case DayOfWeek.Tuesday: return 2;
                case DayOfWeek.Wednesday: return 3;
                case DayOfWeek.Thursday: return 4;
                case DayOfWeek.Friday: return 5;
                case DayOfWeek.Saturday: return 6;
                case DayOfWeek.Sunday: return 7;
            }
            return 0;
        }

        private static int[] GetIncreaseDay(DayOfWeek firstDayOfWeek) {

            int first = GetWeekDay(firstDayOfWeek);

            //Console.WriteLine("First: " + first);

            int[] inc = new int[7];
            int[] v1 = { 6, 5, 4, 3, 2, 1, 0 };

            //first fill
            for (int i = 0, x = 6 - (first - 2); i < first - 1; i++, x++) {
                inc[i] = v1[x];
            }

            //second fill
            for (int i = first - 1, x = 0; i < 7; i++, x++) {
                inc[i] = v1[x];
            }

            return inc;
        }
        
    }

 
}

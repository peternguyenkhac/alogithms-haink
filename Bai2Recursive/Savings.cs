﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2Recursive
{
    public static class Savings
    {
        //Tính số tháng để (tiền gửi + lãi suất) = x2 tiền gửi
        public static int CalMonth(decimal money, decimal rate)
        {
            int month = 0;
            decimal totalAmount = money;
            while (totalAmount < money * 2)
            {
                totalAmount += totalAmount * rate / 100;
                month++;
            }
            return month;
        }

        //Tính số tháng để (tiền gửi + lãi suất) = x2 tiền gửi
        public static int CalMonthRecursive(decimal money, decimal rate)
        {
            return CalMonthToReachAmount(money, money, rate, 0);
        }

        //Tính số tháng để (tiền gửi + lãi suất) = x2 tiền gửi
        //Điều kiện dừng: amount = *2 tiền gửi
        private static int CalMonthToReachAmount(decimal money, decimal amount, decimal rate, int month)
        {
            if (amount > money * 2)
            {
                return month;
            }
            month++;
            amount += amount * rate / 100;
            return CalMonthToReachAmount(money, amount, rate, month);
        }
    }
}
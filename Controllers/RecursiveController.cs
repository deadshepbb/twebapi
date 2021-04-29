using CoreBackend.Api.Dtos;
using CoreBackend.Api.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBackend.Api.Controllers
{
    // https://localhost:44338/api/Recursive/10
    [Route("api/[controller]")]

    public class RecursiveController : Controller
    {

        /// <summary>
        /// 用斐波那契数列里面的前5个数字加起来并返回
        /// </summary>
        /// <param name="num">前num个数字</param>
        /// <returns></returns>
        [Route("{num}")]
        [HttpPost]
        public IActionResult GetRecursive(int num)
        {
            // int.MaxValue 2147483647
            if (num <= 0 || num >=46) return Forbid();

            List<int> datas = new List<int>();
            for (int i = 1; i < num + 1; i++)
            {
                datas.Add(RecUrsive(i));
            }
            return Ok(datas.Sum());
        }

        /// <summary>
        /// 用斐波那契数列里面的前5个数字加起来并返回
        /// </summary>
        /// <param name="num">前num个数字</param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult GetRecursiveData(int num)
        {
            // int.MaxValue 2147483647
            if (num <= 0 || num >= 46) return Forbid();

            List<int> datas = new List<int>();
            for (int i = 1; i < num + 1; i++)
            {
                datas.Add(RecUrsive(i));
            }
            return Ok(datas.Sum());
        }

        // 斐波那契数列：1，1，2，3，5，8，13，21，34，55，……，
        // f(n) = f(n-1)+f(n-2);
        private int RecUrsive(int index)
        {
            if (index < 3)//若index的值等于1或2，则返回1
                return 1;
            else
                return RecUrsive(index - 1) + RecUrsive(index - 2);
        }

    }
}

﻿using FoodUserAuth.DataAccess.Entities;

namespace FoodUserAuth.BusinessLogic.Tests.Utils
{
    public class UsersUtils
    {
        public static int RandomUserMaxCount = 30;

        public static User[] CreateFakeUsers()
        {
            int fakeUserCount = new Random().Next(1, RandomUserMaxCount);
            var users = new List<User>();
            for (int i = 0; i < fakeUserCount; i++)
            {
                users.Add(CreateFakeUser());
            }
            return users.ToArray();
        }

        public static User CreateFakeUser()
        {
            return new User()
            {
                Id = Guid.NewGuid(),
                Email = Faker.Internet.Email(),
                FullName = Faker.Name.FullName(),
                UserName = Faker.Name.First(),
                State = Faker.Enum.Random<UserState>(),
                Password = Faker.Identification.UkNhsNumber()
            };
        }
    }
}
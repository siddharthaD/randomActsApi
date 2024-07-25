using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using RandomActs.Database;

namespace RandomActs.Repository;

public class ActivityRepository : IActivityRepository
{
    private readonly RandomDB _db;

    public ActivityRepository(RandomDB db)
    {
        _db = db; 
    }

    public List<RandomActivity> GetActivities(int count = 1)
    {
        return _db.Activities.ToList();
    }
}
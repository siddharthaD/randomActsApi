using System.Collections.Generic;

namespace RandomActs.Repository;

public interface IActivityRepository
{
    public List<RandomActivity> GetActivities(int count = 1);
}
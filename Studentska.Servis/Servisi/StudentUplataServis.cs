using Microsoft.EntityFrameworkCore;

using Studentska.Data.Entiteti;

namespace Studentska.Servis.Servisi
{
    public class StudentUplataServis : BaseServis<StudentUplata>
    {

        public List<StudentUplata> GetByStudentId(int studentId)
        {
            return _dbContext.StudentiUplate.Include(s=>s.AkademskaGodina).Include(s=>s.VrstaUplate).Where(su => su.StudentId == studentId).ToList();
        }

    }



}

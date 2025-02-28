using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System.Business.Enums
{
    public enum CreateEditCourseStatus
    {
        Success = 1,              // Insert operation successful
        Failed = 0,
        UniqueConstraintViolation = -1, // CourseName already exists
        NotNullViolation = -2,    // Missing required field
        OtherError = -3           // Other database error
    }
}

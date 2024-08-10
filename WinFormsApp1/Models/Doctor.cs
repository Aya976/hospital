using System;
using System.Collections.Generic;

namespace WinFormsApp1.Models;

public partial class Doctor
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public bool Gender { get; set; }

    public long YearOfexperience { get; set; }

    public string MedicalLicenceNumber { get; set; } = null!;
}

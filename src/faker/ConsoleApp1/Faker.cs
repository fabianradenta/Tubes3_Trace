using Bogus;
using Bogus.DataSets;

namespace faker;
public class FakerBiodata {
        public static Biodata generateBiodata() {
            var jenisKelamin = new[] {"Laki-Laki", "Perempuan"};
            var goldar = new[] {"A", "B", "AB", "O"};
            var agama = new[] {"Islam", "Katolik", "Protestan", "Hindu", "Buddha", "Khonghucu"};
            var statusPerkawinan = new[] {"Menikah", "Belum Menikah", "Cerai"};
            var job = new[] {"Wirausaha", "PNS", "Guru", "Dosen", "Dokter", "Insinyur", "Penulis", "Desainer grafis", "Programer", "Akuntan", "Arsitek", "Pengacara", "Pustakawan", "Ilmuwan", "Marketing", "Konsultan", "Psikolog", "Fotografer", "Musisi", "Aktor/Aktris", "Penyiar Radio/TV", "Editor", "Chef", "Petani", "Peneliti", "Perawat", "Diplomat", "Pilot", "Montir", "Pengusaha", "Ahli Kimia", "Teknisi IT", "Dokter Hewan"};
            var faker = new Faker<Biodata>()
                .RuleFor(p => p.nik, f => f.Random.Long(1000000000000000, 9999999999999999))
                .RuleFor(p => p.nama, f => f.Name.FullName())
                .RuleFor(p => p.tempat_lahir, f => f.Address.City())
                .RuleFor(p => p.tanggal_lahir, f => DateOnly.FromDateTime(f.Date.Between(new DateTime(1900,1,1),new DateTime(2007,5,26))))
                .RuleFor(p => p.jenis_kelamin, f => f.PickRandom(jenisKelamin))
                .RuleFor(p => p.golongan_darah, f => f.PickRandom(goldar))
                .RuleFor(p => p.alamat, f => f.Address.FullAddress())
                .RuleFor(p => p.agama, f => f.PickRandom(agama))
                .RuleFor(p => p.status, f => f.PickRandom(statusPerkawinan))
                .RuleFor(p => p.pekerjaan, f => f.PickRandom(job))
                .RuleFor(p => p.kewarganegaraan, f => f.Address.Country());

            Biodata biodata = faker.Generate();
            return biodata;
        }
}
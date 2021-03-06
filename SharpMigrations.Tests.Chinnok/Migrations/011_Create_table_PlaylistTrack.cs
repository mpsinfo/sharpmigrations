namespace SharpMigrations.Tests.Chinnok.Migrations {
    public class _011_Create_table_PlaylistTrack : SchemaMigration {

        public override void Up() {
            Add.Table("PlaylistTrack").WithColumns(
                Column.Int32("PlaylistId").AsPrimaryKey(),
                Column.Int32("TrackId").AsPrimaryKey()
            );
        }

        public override void Down() {
            Remove.Table("PlaylistTrack");
        }
    }
}

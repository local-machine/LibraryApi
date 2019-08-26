using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryApi.Migrations
{
    public partial class UpdatedModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AuthorBook_authors_AuthorId",
                table: "AuthorBook");

            migrationBuilder.DropForeignKey(
                name: "FK_AuthorBook_Books_BookId",
                table: "AuthorBook");

            migrationBuilder.DropForeignKey(
                name: "FK_copies_Books_BookId",
                table: "copies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Books",
                table: "Books");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AuthorBook",
                table: "AuthorBook");

            migrationBuilder.RenameTable(
                name: "Books",
                newName: "books");

            migrationBuilder.RenameTable(
                name: "AuthorBook",
                newName: "authorbook");

            migrationBuilder.RenameIndex(
                name: "IX_AuthorBook_BookId",
                table: "authorbook",
                newName: "IX_authorbook_BookId");

            migrationBuilder.RenameIndex(
                name: "IX_AuthorBook_AuthorId",
                table: "authorbook",
                newName: "IX_authorbook_AuthorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_books",
                table: "books",
                column: "BookId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_authorbook",
                table: "authorbook",
                column: "AuthorBookId");

            migrationBuilder.AddForeignKey(
                name: "FK_authorbook_authors_AuthorId",
                table: "authorbook",
                column: "AuthorId",
                principalTable: "authors",
                principalColumn: "AuthorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_authorbook_books_BookId",
                table: "authorbook",
                column: "BookId",
                principalTable: "books",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_copies_books_BookId",
                table: "copies",
                column: "BookId",
                principalTable: "books",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_authorbook_authors_AuthorId",
                table: "authorbook");

            migrationBuilder.DropForeignKey(
                name: "FK_authorbook_books_BookId",
                table: "authorbook");

            migrationBuilder.DropForeignKey(
                name: "FK_copies_books_BookId",
                table: "copies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_books",
                table: "books");

            migrationBuilder.DropPrimaryKey(
                name: "PK_authorbook",
                table: "authorbook");

            migrationBuilder.RenameTable(
                name: "books",
                newName: "Books");

            migrationBuilder.RenameTable(
                name: "authorbook",
                newName: "AuthorBook");

            migrationBuilder.RenameIndex(
                name: "IX_authorbook_BookId",
                table: "AuthorBook",
                newName: "IX_AuthorBook_BookId");

            migrationBuilder.RenameIndex(
                name: "IX_authorbook_AuthorId",
                table: "AuthorBook",
                newName: "IX_AuthorBook_AuthorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Books",
                table: "Books",
                column: "BookId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AuthorBook",
                table: "AuthorBook",
                column: "AuthorBookId");

            migrationBuilder.AddForeignKey(
                name: "FK_AuthorBook_authors_AuthorId",
                table: "AuthorBook",
                column: "AuthorId",
                principalTable: "authors",
                principalColumn: "AuthorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AuthorBook_Books_BookId",
                table: "AuthorBook",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_copies_Books_BookId",
                table: "copies",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

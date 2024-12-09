using Entities.Models;
using Services.Contracts;
using Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Exceptions;
using AutoMapper;
using Entities.DataTransferObjects;

namespace Services
{
    public class BookManager : IBookService
    {
        private readonly IRepositoryManager _manager;
        private readonly ILoggerService _logger;
        private readonly IMapper _mapper;
        public BookManager (IRepositoryManager manager, ILoggerService logger, IMapper mapper)
        {
            _manager = manager;
            _logger = logger;
            _mapper = mapper;
        }
        public Book CreateOneBook(Book book)
        {

            if(book is null)
            {
                throw new ArgumentNullException(nameof(book));
            }

            _manager.Book.CreateOneBook(book);
            _manager.Save();
            return book;

        }

        public void DeleteOneBook(int id, bool trackchanges)
        {
            var entity = _manager.Book.GetOneBookById(id, trackchanges);

            if (entity is null)
                throw new BookNotFoundException(id);   
            
            _manager.Book.DeleteOneBook(entity);
            _manager.Save();
        }

        public IEnumerable<BookDto> GetAllBooks(bool trackChanges)
        {
            var boks = _manager.Book.GetAllBooks(trackChanges);
            return _mapper.Map<IEnumerable<BookDto>>(boks);
        }

        public Book GetOneBookById(int id, bool trackChanges)
        {
            var book = _manager.Book.GetOneBookById(id, trackChanges);
            if (book is null)
                throw new BookNotFoundException(id);
            return book;
        }

        public void UpdateOneBook(int id, BookDtoForUpdate bookDto, bool trackChanges)
        {
            var entity = _manager.Book.GetOneBookById(id, trackChanges);
            if (entity is null)
                throw new BookNotFoundException(id);




            //entity.Title = bookDto.Title;
            //entity.Price = bookDto.Price;
            entity = _mapper.Map<Book>(bookDto);
            _manager.Book.Update(entity);
            _manager.Save();
        }
        public void PartiallyUpdateOneBook(int id, BookDtoForUpdate bookDto, bool trackChanges)
        {
            throw new NotImplementedException();
        }

    }

   
}

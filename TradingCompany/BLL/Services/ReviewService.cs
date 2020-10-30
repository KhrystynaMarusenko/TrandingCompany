using AutoMapper;
using BLL.Views;
using DAL.Concrete;
using DTO;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class ReviewService
    {
        private readonly ReviewDal _reviewDal;
        private readonly ItemDal _itemDal;
        private readonly UserDal _userDal;
        private readonly IMapper _mapper;

        public ReviewService(ReviewDal reviewDal, ItemDal itemDal, UserDal userDal, IMapper mapper)
        {
            _reviewDal = reviewDal;
            _itemDal = itemDal;
            _userDal = userDal;
            _mapper = mapper;
        }

        public IEnumerable<ReviewViewModel> GetByItem(string itemName)
        {
            IEnumerable<ReviewDTO> revsDTO = this.GetAll();

            List<ReviewViewModel> models = new List<ReviewViewModel>();            
            foreach(var rev in revsDTO)
            {
                models.Add(DTOToView(rev));
            }
            
            return models;
        }


        public IEnumerable<ReviewDTO> SortByDate(List<ReviewDTO> reviewsDTO)
        {
            return reviewsDTO.OrderBy(obj => obj.DateTime);
        }

        public IEnumerable<ReviewDTO> SortByUser(List<ReviewDTO> reviewsDTO)
        {
            return reviewsDTO.OrderBy(obj => obj.user.Login);
        }

        public IEnumerable<ReviewViewModel> GetViewModels()
        {
            IEnumerable<ReviewDTO> revsDTO = GetAll();
            var revsView = revsDTO.ToList().ConvertAll(x => _mapper.Map<ReviewDTO, ReviewViewModel>(x));
            return revsView;
        }

        public IEnumerable<ReviewDTO> GetAll()
        {
            List<ReviewDTO> revsDTO = new List<ReviewDTO>();
            foreach (var review in _reviewDal.GetAll())
            {
                ReviewDTO reviewDTO = GetById(review.Id);
                revsDTO.Add(reviewDTO);
            }
            return revsDTO;
        }

        public ReviewViewModel DTOToView(ReviewDTO review)
        {
            ReviewViewModel model = new ReviewViewModel();
            model.Id = review.Id;
            model.Item = review.item.Name;
            model.User = review.user.Login;
            model.Text = review.Text;
            model.DateTime = review.DateTime;
            return model;
        }

        public ReviewDTO GetById(int id)
        {
            Review review = _reviewDal.GetById(id);
            ReviewDTO reviewDTO = new ReviewDTO();
            reviewDTO.Id = id;
            reviewDTO.item = _itemDal.GetById(review.ItemId);
            reviewDTO.user = _userDal.GetById(review.UserId);
            reviewDTO.Text = review.Text;
            reviewDTO.DateTime = review.DateTime;
            return reviewDTO;
        }
    }
}

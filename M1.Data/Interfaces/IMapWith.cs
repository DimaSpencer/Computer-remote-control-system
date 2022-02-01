using AutoMapper;

namespace M1.Domain.Interfaces
{
    public interface IMapWith<T>
    {
        void Mapping(Profile profile) =>
            profile.CreateMap(typeof(T), GetType(), MemberList.Destination);
    }
}
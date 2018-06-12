using DEMO09.BusinessInterfaces;
using DEMO09.DataInterfaces;
using DEMO09.Types;
using System;
using System.Collections.Generic;

namespace DEMO09.BusinessLayer
{
    public class TaxProfileProcessor : ITaxProfileProcessor
    {
        private readonly ITaxProfileRepository _TaxProfileRepository;


        public TaxProfileProcessor(ITaxProfileRepository TaxProfileRepository)
        {
            _TaxProfileRepository = TaxProfileRepository;
        }

        public void AddTaxProfile(TaxProfileType item)
        {
            //OBSERVACION: 
            //Nos damos cuenta algunas de las validaciones podrian o no hacerse (por ej. checar si existe el registro o no)
            //ya que las validaciones pueden a nivel base de datos con constraint, es decir el registro existe y intentamos agregar un nuevo
            //usuario con la misma clave, tronara la transaccion si la tiene un constraint o llave primaria de esa clave.
            //como posible ventaja es utilizar angular para ir validando el campo cada vez que salimos de un contol (caja de texto, grid, etc) antes de enviar todos
            //los datos a la BD.

            TaxProfileType item2 = _TaxProfileRepository.FindTaxProfileByIdentification(item.Identification);
            if ( item2 != null)
            {
                throw new Exception($"Este RFC ya se encuentra registrado para la entidad {item2.Name}");
            }
            _TaxProfileRepository.AddTaxProfile(item);
        }

        public IEnumerable<TaxProfileType> FindAllTaxProfiles()
        {
            return _TaxProfileRepository.FindAllTaxProfiles();
        }

        public TaxProfileType FindTaxProfileById(int Id)
        {
            return _TaxProfileRepository.FindTaxProfileById(Id);
        }

        public TaxProfileType FindTaxProfileByIdentification(string Identification)
        {
            return _TaxProfileRepository.FindTaxProfileByIdentification(Identification);
        }

        public void RemoveTaxProfile(int Id)
        {
            try
            {
                if (_TaxProfileRepository.RemoveTaxProfile(Id) == 0)
                {
                    throw new Exception($"Algo salio mal, no se encontró el registro");
                }
            }
            catch (Exception ex)
            {
                //FALTA:Guardar en Log el error real.
                throw new Exception("Algo salió bastante mal");
            }
        }

        public void UpdateTaxProfile(TaxProfileType item)
        {
            try
            {
                if (_TaxProfileRepository.UpdateTaxProfile(item) == 0)
                {
                    throw new Exception($"Algo salio mal, no se encontró el registro con identificación {item.Identification}");
                }
            }
            catch (Exception ex)
            {
                //FALTA: Guardar en Log el error real.
                throw new Exception("Algo salió bastante mal");
            }
        }
    }
}

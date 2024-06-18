using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using Cantina;
using GereCantina.Models;

namespace Cantina.Controllers
{
    public class MenuController
    {
        // CRUD de Menus
        public void AdicionarMenu(Menu menu, List<Prato> pratos, List<Extra> extras)
        {
            using (var db = new CantinaContext())
            {
                // Desanexar menu do contexto atual
                db.Entry(menu).State = EntityState.Detached;

                // Criar listas temporárias para pratos e extras
                var pratosToAdd = new List<Prato>();
                var extrasToAdd = new List<Extra>();

                // Adicionar pratos ao menu
                foreach (var prato in pratos)
                {
                    var pratoExistente = db.Pratos.Find(prato.id); // Buscar prato existente no banco de dados, se necessário
                    if (pratoExistente != null)
                        pratosToAdd.Add(pratoExistente); // Adicionar prato existente
                    else
                        pratosToAdd.Add(prato); // Adicionar novo prato
                }

                // Adicionar extras ao menu
                foreach (var extra in extras)
                {
                    var extraExistente = db.Extras.Find(extra.Id); // Buscar extra existente no banco de dados, se necessário
                    if (extraExistente != null)
                        extrasToAdd.Add(extraExistente); // Adicionar extra existente
                    else
                        extrasToAdd.Add(extra); // Adicionar novo extra
                }

                // Atribuir listas temporárias ao menu
                menu.Pratos = pratosToAdd;
                menu.Extras = extrasToAdd;

                // Adicionar o menu ao contexto
                db.Menus.Add(menu);

                // Salvar as alterações no banco de dados
                db.SaveChanges();
            }
        }

        // Retrieve a menu by its ID with associated pratos and extras
        public Menu BuscarMenuPorId(int id)
        {
            using (var db = new CantinaContext())
            {
                // Load the menu by its ID
                var menu = db.Menus.Include(m => m.Pratos).Include(m => m.Extras).FirstOrDefault(m => m.Id == id);

                // Ensure that the menu object is not null
                if (menu != null)
                {
                    // Explicitly load the Pratos and Extras collections
                    db.Entry(menu).Collection(m => m.Pratos).Load();
                    db.Entry(menu).Collection(m => m.Extras).Load();
                }

                return menu;
            }
        }

        public void RemoverMenu(Menu menu)
        {
            // Remover Menu
            using (var db = new CantinaContext())
            {
                db.Entry(menu).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public void AtualizarMenu(Menu menu)
        {
            using (var db = new CantinaContext())
            {
                var existingMenu = db.Menus
                                     .Include(m => m.Pratos)
                                     .Include(m => m.Extras)
                                     .FirstOrDefault(m => m.Id == menu.Id);

                if (existingMenu != null)
                {
                    try
                    {
                        // Update scalar properties of existingMenu
                        existingMenu.DataHora = menu.DataHora;
                        existingMenu.QtdDisponivel = menu.QtdDisponivel;
                        existingMenu.PrecoEstudante = menu.PrecoEstudante;
                        existingMenu.PrecoProfessor = menu.PrecoProfessor;

                        // Update or add Pratos
                        foreach (var prato in menu.Pratos)
                        {
                            var existingPrato = existingMenu.Pratos.FirstOrDefault(p => p.id == prato.id);
                            if (existingPrato != null)
                            {
                                db.Entry(existingPrato).CurrentValues.SetValues(prato);
                            }
                            else
                            {
                                existingMenu.Pratos.Add(prato);
                            }
                        }

                        // Update or add Extras
                        foreach (var extra in menu.Extras)
                        {
                            var existingExtra = existingMenu.Extras.FirstOrDefault(e => e.Id == extra.Id);
                            if (existingExtra != null)
                            {
                                db.Entry(existingExtra).CurrentValues.SetValues(extra);
                            }
                            else
                            {
                                existingMenu.Extras.Add(extra);
                            }
                        }

                        // Remove Pratos that are no longer associated with the Menu
                        foreach (var prato in existingMenu.Pratos.ToList())
                        {
                            if (!menu.Pratos.Any(p => p.id == prato.id))
                            {
                                existingMenu.Pratos.Remove(prato);
                            }
                        }

                        // Remove Extras that are no longer associated with the Menu
                        foreach (var extra in existingMenu.Extras.ToList())
                        {
                            if (!menu.Extras.Any(e => e.Id == extra.Id))
                            {
                                existingMenu.Extras.Remove(extra);
                            }
                        }

                        db.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception($"Erro ao atualizar o menu: {ex.Message}");
                    }
                }
                else
                {
                    throw new Exception($"Menu com ID {menu.Id} não encontrado no banco de dados.");
                }
            }
        }

        public List<Menu> ListarMenus()
        {
            // Listar Menu
            using (var db = new CantinaContext())
            {
                return db.Menus.ToList();
            }
        }
    }
}
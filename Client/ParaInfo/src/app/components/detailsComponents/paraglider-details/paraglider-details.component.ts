import { Component, Input, OnInit } from '@angular/core';
import { GetProductsService } from 'src/app/services/get-products.service';

@Component({
  selector: 'app-paraglider-details',
  templateUrl: './paraglider-details.component.html',
  styleUrls: ['./paraglider-details.component.css']
})
export class ParagliderDetailsComponent implements OnInit {
  @Input() brand: string = "";
  @Input() model: string = "";
  showDescription:boolean = true;
  paraglider: any
  constructor(private productsService:GetProductsService) {
   }

  ngOnInit(): void {
    this.productsService.getOne("paraglider",this.brand,this.model).subscribe(data => {
      this.paraglider = data;
    })
  }
  isArray(x:any){
    return x instanceof Array;
  }

  deleteParaglider(){

  }

  toggleDescription() {
    this.showDescription = !this.showDescription
  }
}
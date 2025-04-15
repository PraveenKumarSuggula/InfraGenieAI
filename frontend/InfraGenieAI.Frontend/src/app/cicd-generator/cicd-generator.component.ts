import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { cicdGenerationRequest } from 'src/models/cicd-generator';
import { CicdGeneratorService } from 'src/services/cicd-generator.service';

@Component({
  selector: 'app-cicd-generator',
  templateUrl: './cicd-generator.component.html',
  styleUrls: ['./cicd-generator.component.scss']
})
export class CicdGeneratorComponent implements OnInit {

  yaml: string = `## Markdown __rulez__!
---

### Syntax highlight
\`\`\`typescript
const language = 'typescript';
\`\`\`

### Lists
1. Ordered list
2. Another bullet point
   - Unordered list
   - Another unordered bullet

### Blockquote
> Blockquote to the max
`;


form: FormGroup;
  platforms = ['GitHub Actions', 'Azure DevOps'];
  targets = ['Azure App Service', 'Docker'];

  constructor(private fb: FormBuilder, private cicdGeneratorService: CicdGeneratorService) {
    this.form = this.fb.group({
      language: ['.NET'],
      platform: ['GitHub Actions'],
      deploymentTarget: ['Azure App Service']
    });
  }

  ngOnInit(): void {

  }

  onGenerateCode(){
    const formData: cicdGenerationRequest = this.form.value;
    this.cicdGeneratorService.onGenerate(formData).subscribe((yaml:string) => this.yaml = yaml);
  }
}

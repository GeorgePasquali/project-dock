import { ProjectDockTemplatePage } from './app.po';

describe('abp-project-name-template App', function() {
  let page: ProjectDockTemplatePage;

  beforeEach(() => {
    page = new ProjectDockTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
